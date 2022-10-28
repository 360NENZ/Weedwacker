using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByNot : BasePredicate
    {
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
