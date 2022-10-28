using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetGlobalValue : BasePredicate
    {
        [JsonProperty] public readonly string key;
        [JsonProperty] public readonly object value; //TODO string[] or float
        [JsonProperty] public readonly bool forceByCaster;
    }
}
