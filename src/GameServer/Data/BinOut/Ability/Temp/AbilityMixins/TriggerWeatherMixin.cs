using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class TriggerWeatherMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly TriggerType type;
        [JsonProperty] public readonly string weatherPattern;
        [JsonProperty] public readonly float transDuration;
        [JsonProperty] public readonly float duration;
    }
}
