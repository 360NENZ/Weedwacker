using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetIsCaster : BasePredicate
    {
        [JsonProperty] public readonly bool isCaster;
    }
}
