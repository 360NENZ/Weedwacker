using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHitEnBreak : BasePredicate
    {
        [JsonProperty] public readonly float enBreak;
    }
}
