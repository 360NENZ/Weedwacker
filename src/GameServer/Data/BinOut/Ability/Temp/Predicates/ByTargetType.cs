using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetType : BasePredicate
    {
        [JsonProperty] public readonly bool isTarget;
    }
}
