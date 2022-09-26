using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data.BinOut.Talent.AvatarTalents;
using Weedwacker.GameServer.Data.Excel;

namespace Weedwacker.GameServer.Systems.Avatar
{
    internal class SkillDepot
    {
        public int DepotId { get; private set; }
        [BsonIgnore]
        private Player.Player Owner; // Loaded by DatabaseManager
        [BsonIgnore]
        private Avatar Avatar; // Loaded by DatabaseManager
        public int EnergySkill { get; private set; } // Ultimate elemental ability (Q)
        public int EnergySkillLevel { get; private set; }
        public ElementType Element { get; private set; } // Stores current and max energy
        public int[] Abilities { get; private set; } // Just the hashes
        public SortedList<int, int> Skills { get; private set; } // <skillId,level>
        public SortedList<int, int> SubSkills { get; private set; } // <skillId,level>
        public Dictionary<int, int> SkillExtraChargeMap { get; private set; } = new(); // Charges
        public List<ProudSkillData> InherentProudSkillOpens { get; private set; } = new(); // proudSkillId
        public List<AvatarTalentData> Talents { get; private set; } = new(); // last digit of id = constellationRank
        public Dictionary<string, AvatarTalentConfigData> TalentConfigs { get; private set; } = new();
        public Dictionary<int, int> proudSkillExtraLevelMap { get; private set; } // <groupId,extraLevels>
        public Dictionary<int, int> proudSkillBonusMap { get; private set; }
        public SkillDepot(Avatar avatar, int depotId, Player.Player owner)
        {
            Owner = owner;
            Avatar = avatar;
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
            await Task.Run(() => Owner = owner);
            await Task.Run(() => Avatar = avatar);
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
    }
}
