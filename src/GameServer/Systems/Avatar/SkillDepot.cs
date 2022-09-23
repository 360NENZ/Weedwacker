using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data.BinOut.Talent.AvatarTalents;
using Weedwacker.GameServer.Data.Excel;

namespace Weedwacker.GameServer.Systems.Avatar
{
    internal class SkillDepot
    {
        public int OwnerId;
        public readonly int DepotId;
        [BsonIgnore]
        public readonly Database.Player Owner;
        public readonly int EnergySkill; // Ultimate elemental ability (Q)
        public readonly int EnergySkillLevel;
        public  ElementType Element; // Stores current and max energy
        public int[] Abilities; // Just the hashes
        public readonly SortedList<int, int> Skills; // <skillId,level>
        public readonly SortedList<int, int> SubSkills; // <skillId,level>
        public readonly Dictionary<int, int> SkillExtraChargeMap = new(); // Charges
        public readonly List<ProudSkillData> InherentProudSkillOpens = new(); // proudSkillId
        public readonly List<AvatarTalentData> Talents = new(); // last digit of id = constellationRank
        public readonly Dictionary<string, AvatarTalentConfigData> TalentConfigs = new();
        public readonly Dictionary<int, int> proudSkillExtraLevelMap; // <groupId,extraLevels>
        public readonly Dictionary<int, int> proudSkillBonusMap; // <groupId,extraLevels>

        public SkillDepot(int avatarId, int depotId)
        {
            DepotId = depotId;
            var avatar = GameServer.AvatarInfo[avatarId];
            EnergySkill = avatar.SkillDepotData[depotId].energySkill;
            EnergySkillLevel = 1;
            Element = (ElementType)Activator.CreateInstance(Type.GetType(avatar.SkillData[depotId][EnergySkill].costElemType));
            Element.MaxEnergy = avatar.SkillData[depotId][EnergySkill].costElemVal;
            Abilities = avatar.AbilityNameHashes[depotId];
            var inherentProudSkillGroups = avatar.SkillDepotData[depotId].inherentProudSkillOpens.Where(w => w.needAvatarPromoteLevel <= 1).ToDictionary(q => q.proudSkillGroupId).Keys.ToList();
            foreach (int group in inherentProudSkillGroups)
            {
                var idList = avatar.ProudSkillData[depotId].Where(w => w.Value.proudSkillGroupId == group).ToDictionary(q => q.Key).Keys.ToList();
                foreach (int id in idList)
                {
                    InherentProudSkillOpens.Add(avatar.ProudSkillData[depotId][id]);
                }
            }
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
