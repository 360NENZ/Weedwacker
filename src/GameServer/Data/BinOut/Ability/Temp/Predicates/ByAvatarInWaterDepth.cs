using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByAvatarInWaterDepth : BasePredicate
    {
        [JsonProperty] public readonly string compareType;
        [JsonProperty] public readonly float depth;
    }
}
