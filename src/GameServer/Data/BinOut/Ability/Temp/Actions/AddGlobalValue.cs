using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AddGlobalValue : BaseAction
    {
        [JsonProperty] public readonly object value; //TODO string[] or float
        [JsonProperty] public readonly string key;
        [JsonProperty] public readonly bool useLimitRange;
        [JsonProperty] public readonly object maxValue; //TODO string or float
        [JsonProperty] public readonly object minValue; //TODO string or float
    }
}
