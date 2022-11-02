using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHasAbilityState : BasePredicate
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly AbilityState abilityState;
    }
}
