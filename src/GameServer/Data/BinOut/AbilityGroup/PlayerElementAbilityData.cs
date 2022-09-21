using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.AbilityGroup
{
    internal class PlayerElementAbilityData : GameResource
    {
        [JsonProperty]
        public readonly string abilityGroupSourceType;
        [JsonProperty]
        public readonly string abilityGroupTargetType;
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
