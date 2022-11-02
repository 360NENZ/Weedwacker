using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetIsSelf : BasePredicate
    {
        [JsonProperty] public readonly bool isSelf;
    }
}
