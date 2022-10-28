using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class TriggerElementSupportMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float duration;
        [JsonProperty] public readonly ElementType elementType;
    }
}
