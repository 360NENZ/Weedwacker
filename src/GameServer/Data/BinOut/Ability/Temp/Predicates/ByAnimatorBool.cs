using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByAnimatorBool : BasePredicate
    {
        [JsonProperty] public readonly bool value;
        [JsonProperty] public readonly string parameter;
    }
}
