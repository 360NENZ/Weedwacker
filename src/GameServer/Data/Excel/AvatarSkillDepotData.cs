using Newtonsoft.Json;
using Weedwacker.GameServer.Systems.Avatar;
using static Weedwacker.GameServer.Data.ResourceAttribute;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarSkillDepotExcelConfigData.json", LoadPriority.HIGH)]
    internal class AvatarSkillDepotData
    {
        [JsonProperty]
        public readonly int id;
        [JsonProperty]
        public readonly int energySkill;
        [JsonProperty]
        public readonly int attackModeSkill;
        [JsonProperty]
        public readonly List<int>? skills;
        [JsonProperty]
        public readonly List<int>? subSkills;
        [JsonProperty]
        public readonly int leaderTalent;
        [JsonProperty]
        public readonly List<string>? extraAbilities;
        [JsonProperty]
        public readonly List<int>? talents;
        [JsonProperty]
        public readonly List<InherentProudSkillOpens>? inherentProudSkillOpens;
        [JsonProperty]
        public readonly string? talentStarName;
        [JsonProperty]
        public readonly string? skillDepotAbilityGroup;

        public class InherentProudSkillOpens
        {
            [JsonProperty]
            public readonly int? proudSkillGroupId;
            [JsonProperty]
            public readonly int? needAvatarPromoteLevel;
        }
    }
}
