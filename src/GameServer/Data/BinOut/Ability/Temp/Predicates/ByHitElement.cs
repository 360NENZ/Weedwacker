using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHitElement : BasePredicate
    {
        [JsonProperty] public readonly ElementType element;
    }
}
