using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal class ConfigAbility : BaseConfigAbility
    {
        [JsonProperty] public readonly string abilityName;
        [JsonProperty] public readonly BaseAbilityMixin[] abilityMixins;
        [JsonProperty] public readonly Dictionary<string, float>? abilitySpecials;
        [JsonProperty] public readonly BaseAction[] onAbilityStart;
        [JsonProperty] public readonly bool isDynamicAbility;
    }
}
