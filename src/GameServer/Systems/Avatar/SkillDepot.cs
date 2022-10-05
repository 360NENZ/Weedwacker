using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data.BinOut.Talent.AvatarTalents;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Common.ConfigTalentTypes;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Player;

namespace Weedwacker.GameServer.Systems.Avatar
{
    internal class SkillDepot
    {
        public int DepotId { get; private set; }
        [BsonIgnore]
        private Player.Player Owner; // Loaded by DatabaseManager
        [BsonIgnore]
        private Avatar Character; // Loaded by DatabaseManager
        public ushort PromoteLevel = 0; // Constellation rank
        public int EnergySkill { get; private set; } // Ultimate elemental ability (Q)
        public int EnergySkillLevel { get; private set; }
        public ElementType Element { get; private set; } // Stores current and max energy
        public int[] Abilities { get; private set; } // Just the hashes
        public SortedList<int, int> Skills { get; private set; } // <skillId,level>
        public SortedList<int, int> SubSkills { get; private set; } // <skillId,level>
        public Dictionary<int, int> SkillExtraChargeMap { get; private set; } = new(); // Charges
        public List<ProudSkillData> InherentProudSkillOpens { get; private set; } = new(); // proudSkillId
        public List<AvatarTalentData> Talents { get; private set; } = new(); // last digit of id = constellationRank. Also contain the openConfig name, which is needed to apply AbilityEmbryos
        //TODO
        public Dictionary<int, int> ProudSkillExtraLevelMap { get; private set; } // <groupId,extraLevels> 

        public SkillDepot(Avatar avatar, int depotId, Player.Player owner)
        {
            Owner = owner;
            Character = avatar;
            DepotId = depotId;
            var avatarInfo = GameServer.AvatarInfo[avatar.AvatarId];
            EnergySkill = avatarInfo.SkillDepotData[depotId].energySkill;
            EnergySkillLevel = 1;
            Element = (ElementType)Activator.CreateInstance(Type.GetType(avatarInfo.SkillData[depotId][EnergySkill].costElemType));
            Element.MaxEnergy = avatarInfo.SkillData[depotId][EnergySkill].costElemVal;
            Abilities = avatarInfo.AbilityNameHashes[depotId];
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
            // 6 if all unlocked
            if (Talents.Count == 6) return 6;
            // The Highest unlocked constellation rank (we can keep some lower ranks locked like this)
            else return uint.Parse(new char[1] { Talents.Max().ToString().ToCharArray().Last() }); // hurr durr I can't parse a single char
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
            if (! await Owner.Inventory.PayPromoteCostAsync(proudSkill.GetTotalCostItems())) return false;

            // Upgrade skill        
            return await SetSkillLevel(skillId, newLevel);
        }

        public async Task<bool> SetSkillLevel(int skillId, int level)
        {
            if (level < 0 || level > 15) return false;
            int oldLevel = Skills.GetValueOrDefault(skillId, 0);  
            Skills[skillId] = level;

            // Update Database
            var updateQuery = new UpdateQueryBuilder<AvatarManager>();
            updateQuery.SetFilter(w => w.OwnerId == Owner.GameUid);
            updateQuery.AddValueToSet(w => w.Avatars[Character.AvatarId].SkillDepots[DepotId].Skills[skillId], level);
            Tuple<string, string> updateString = updateQuery.Build();
            var result = await DatabaseManager.UpdateAvatarsAsync(updateString);

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
            var updateQuery = new UpdateQueryBuilder<AvatarManager>();
            updateQuery.SetFilter(w => w.OwnerId == Owner.GameUid);
            updateQuery.AddValueToSet(w => w.Avatars[Character.AvatarId].SkillDepots[DepotId].Talents, Talents);
            Tuple<string, string> updateString = updateQuery.Build();
            var result = await DatabaseManager.UpdateAvatarsAsync(updateString);

            // Packet
            await Owner.SendPacketAsync(new PacketAvatarUnlockTalentNotify(Character, DepotId, talentId));
            
            //TODO openConfigs

            // Recalc + save avatar
            await Character.RecalcStatsAsync(true);

            return true;
        }
    }
}
