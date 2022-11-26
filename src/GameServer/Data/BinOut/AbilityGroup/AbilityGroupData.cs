using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
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
    }
}
