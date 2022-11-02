using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetOverrideMapValue : BasePredicate
    {
        [JsonProperty] public readonly LogicType logic;
        [JsonProperty] public readonly string targetAbilityName;
        [JsonProperty] public readonly string targetKey;
        [JsonProperty] public readonly object targetValue;
    }
}
