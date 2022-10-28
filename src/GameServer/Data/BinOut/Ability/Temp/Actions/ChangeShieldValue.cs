using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ChangeShieldValue : BaseAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly string modifierName;
        [JsonProperty] public readonly object shieldHPRatio; //TODO string or float
        [JsonProperty] public readonly object shieldHP; //TODO string or float
        [JsonProperty] public readonly object maxShieldByHPRatio; //TODO string or float
        [JsonProperty] public readonly object maxShieldHP; //TODO string or float
        [JsonProperty] public readonly bool doOffStage;
    }
}
