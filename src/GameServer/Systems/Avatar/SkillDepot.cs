using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Avatar
{
    internal class SkillDepot
    {
        [BsonElement] public int DepotId { get; private set; }
        [BsonIgnore] private Player.Player Owner; // Loaded by DatabaseManager
        [BsonIgnore] private Avatar Character; // Loaded by DatabaseManager
        [BsonElement] public ushort PromoteLevel = 0; // Constellation rank
        [BsonElement] public int EnergySkill { get; private set; } // Ultimate elemental ability (Q)
        [BsonElement] public int EnergySkillLevel { get; private set; }
        [BsonElement] public ElementType? Element { get; private set; } // Stores current and max energy
        [BsonElement] public ulong[] Abilities { get; private set; } // Just the hashes
        [BsonElement] public SortedList<int, int> Skills { get; private set; } = new(); // <skillId,level>
        [BsonElement] public SortedList<int, int> SubSkills { get; private set; } = new(); // <skillId,level>
        [BsonElement] public SortedList<int, int> SkillExtraChargeMap { get; private set; } = new(); // Charges
        [BsonElement] public HashSet<ProudSkillData> InherentProudSkillOpens { get; private set; } = new(); // proudSkillId
        [BsonElement] public HashSet<AvatarTalentData> Talents { get; private set; } = new(); // last digit of id = constellationRank. Also contain the openConfig name, which is needed to apply AbilityEmbryos
        //TODO
        [BsonElement] public SortedList<int, int> ProudSkillExtraLevelMap { get; private set; } = new(); // <groupId,extraLevels> 

        public SkillDepot(Avatar avatar, int depotId, Player.Player owner)
        {
            Owner = owner;
            Character = avatar;
            DepotId = depotId;
            var avatarInfo = GameServer.AvatarInfo[avatar.AvatarId];
            EnergySkill = avatarInfo.SkillDepotData[depotId].energySkill;
            // Hero Avatars don't have an element at the beginning
            if (EnergySkill != 0)
            {
                EnergySkillLevel = 1;
                Enums.ElementType type = avatarInfo.SkillData[depotId][EnergySkill].costElemType;
                switch (type)
                {
                    case Enums.ElementType.Fire:
                        Element = new Fire();
                        break;
                    case Enums.ElementType.Water:
                        Element = new Water();
                        break;
                    case Enums.ElementType.Wind:
                        Element = new Wind();
                        break;
                    case Enums.ElementType.Ice:
                        Element = new Ice();
                        break;
                    case Enums.ElementType.Rock:
                        Element = new Rock();
                        break;
                    case Enums.ElementType.Electric:
                        Element = new Electric();
                        break;
                    case Enums.ElementType.Grass:
                        Element = new Grass();
                        break;
                    default:
                        Logger.WriteErrorLine("Unknown Avatar Element Type");
                        break;
                }
                Element.MaxEnergy = avatarInfo.SkillData[depotId][EnergySkill].costElemVal;
            }

            foreach (int skillId in avatarInfo.SkillDepotData[depotId].skills)
            { 
                if (skillId != 0) Skills.Add(skillId, 1); 
            }

            if (avatarInfo.AbilityNameHashes.TryGetValue(depotId, out ulong[]? hashes))
                Abilities = hashes;

            var inherentProudSkillGroups = avatarInfo.SkillDepotData[depotId].inherentProudSkillOpens.Where(w => w.needAvatarPromoteLevel <= 1).ToDictionary(q => q.proudSkillGroupId).Keys.ToList();
            foreach (int group in inherentProudSkillGroups)
            {
                var idList = avatarInfo.ProudSkillData[depotId].Where(w => w.Value.proudSkillGroupId == group).ToDictionary(q => q.Key).Keys.ToList();
                foreach (int id in idList)
                {
                    InherentProudSkillOpens.Add(avatarInfo.ProudSkillData[depotId][id]);
                }
            }
        }

        public async Task OnLoadAsync(Player.Player owner, Avatar avatar)
        {
            Owner = owner;
            Character = avatar;
        }
        public uint GetCoreProudSkillLevel()
        {
            return (uint)Talents.Count;
        }

        public List<int> GetSkillsAndEnergySkill()
        {
            var list = Skills.Values.Where(w => w > 0).ToList();
            list.Add(EnergySkill);
            return list;

        }
        public Dictionary<int, int> GetSkillLevelMap()
        {
            Dictionary<int, int> skillz = new()
            {
                { EnergySkill, EnergySkillLevel }
            };
            foreach (int skill in Skills.Keys)
            {
                skillz.Add(skill, Skills[skill]);
            }

            return skillz;
        }

        public async Task<bool> UpgradeSkill(int skillId)
        {
            AvatarSkillData skillData = GameServer.AvatarInfo[Character.AvatarId].SkillData[DepotId][skillId];
            if (skillData == null) return false;

            // Get data for next skill level
            int newLevel = Skills.GetValueOrDefault(skillId, 0) + 1;
            if (newLevel > 10) return false;

            // Proud skill data
            ProudSkillData proudSkill = GameServer.AvatarInfo[Character.AvatarId].ProudSkillData[DepotId]
                .Where(w => w.Value.proudSkillGroupId == skillData.proudSkillGroupId && w.Value.level == newLevel).First().Value;

            // Make sure break level is correct
            if (Character.PromoteLevel < proudSkill.breakLevel) return false;

            // Pay materials and mora if possible
            if (!await Owner.Inventory.PayPromoteCostAsync(proudSkill.GetTotalCostItems())) return false;

            // Upgrade skill        
            return await SetSkillLevel(skillId, newLevel);
        }

        internal async Task SendAvatarSkillInfoNotify()
        {
            if (!SkillExtraChargeMap.Any()) return;
            await Owner.SendPacketAsync(new PacketAvatarSkillInfoNotify(Character.Guid, SkillExtraChargeMap));
        }

        public async Task<bool> SetSkillLevel(int skillId, int level)
        {
            if (level < 0 || level > 15) return false;
            int oldLevel = Skills.GetValueOrDefault(skillId, 0);
            Skills[skillId] = level;

            // Update Database
            var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update = Builders<AvatarManager>.Update.Set(w => w.Avatars[Character.AvatarId].SkillDepots[DepotId].Skills[skillId], level);
            await DatabaseManager.UpdateAvatarsAsync(filter, update);

            // Packet
            await Owner.SendPacketAsync(new PacketAvatarSkillChangeNotify(Character, DepotId, skillId, oldLevel, level));

            return true;
        }
        public async Task<bool> UnlockConstellation(int talentId, bool skipPayment = false)
        {
            // Get talent
            AvatarTalentData talentData = GameServer.AvatarInfo[Character.AvatarId].TalentData[DepotId][talentId];
            if (talentData == null) return false;

            // Pay constellation item if possible
            if (!skipPayment && !await Owner.Inventory.PayPromoteCostAsync(new ItemParamData[] { new ItemParamData(talentData.mainCostItemId, 1) })) // don't judge...
            {
                return false;
            }

            // Apply + recalc
            Talents.Add(talentData);

            // Update Database
            var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update = Builders<AvatarManager>.Update.Set(w => w.Avatars[Character.AvatarId].SkillDepots[DepotId].Talents, Talents);
            await DatabaseManager.UpdateAvatarsAsync(filter, update);

            // Packet
            await Owner.SendPacketAsync(new PacketAvatarUnlockTalentNotify(Character, DepotId, talentId));

            //TODO openConfigs

            // Recalc + save avatar
            await Character.RecalcStatsAsync(true);

            return true;
        }
    }
}
