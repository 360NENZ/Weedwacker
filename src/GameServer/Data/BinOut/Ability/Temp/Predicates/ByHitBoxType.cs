using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHitBoxType : BasePredicate
    {
        [JsonProperty] public readonly string hitBoxType;
    }
}
