using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class Predicated : BaseAction
    {
        [JsonProperty] public readonly BasePredicate[] targetPredicates;
        [JsonProperty] public readonly BaseAction[] successActions;
        [JsonProperty] public readonly BaseAction[] failActions;
    }
}
