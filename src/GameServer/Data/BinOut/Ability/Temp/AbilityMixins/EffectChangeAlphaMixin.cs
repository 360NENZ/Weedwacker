using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class EffectChangeAlphaMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly float startDuration;
        [JsonProperty] public readonly float endDuration;
    }
}
