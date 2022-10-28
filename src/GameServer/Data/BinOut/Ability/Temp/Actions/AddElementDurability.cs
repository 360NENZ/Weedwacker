using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AddElementDurability : BaseAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly object value; //TODO string or string[]
        [JsonProperty] public readonly string modifierName;
        [JsonProperty] public readonly bool useLimitRange;
        [JsonProperty] public readonly string[] maxValue;
        [JsonProperty] public readonly float minValue;
    }
}
