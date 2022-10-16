using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.AbilityGroup
{
    internal class AbilityGroupData
    {
        [JsonProperty]
        public readonly AbilityGroupSourceType abilityGroupSourceType;
        [JsonProperty]
        public readonly AbilityGroupTargetType abilityGroupTargetType;
        [JsonProperty]
        public readonly List<TargetAbility> targetAbilities;
            
        public class TargetAbility
        {
            [JsonProperty]
            public readonly string abilityID;
            [JsonProperty]
            public readonly string abilityName;
            [JsonProperty]
            public readonly string abilityOverride;
        }
    }
}
