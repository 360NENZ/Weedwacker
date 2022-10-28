using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetGlobalValue : BaseAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly object value; //TODO string[] or float
        [JsonProperty] public readonly string key;
        [JsonProperty] public readonly object maxValue; //TODO string or float
        [JsonProperty] public readonly float minValue;
    }
}
