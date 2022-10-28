using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToNormalizedTimeMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string stateID;
        [JsonProperty] public readonly string modifierName;
        [JsonProperty] public readonly float normalizeStart;
    }
}
