using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class TriggerWitchTimeMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly TargetType ignoreTargetType;
        [JsonProperty] public readonly string weatherPattern;
    }
}
