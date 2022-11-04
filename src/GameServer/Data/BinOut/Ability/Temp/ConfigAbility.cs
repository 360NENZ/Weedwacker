using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal class ConfigAbility : BaseConfigAbility
    {
        [JsonProperty] public readonly string abilityName;
        [JsonProperty] public readonly Dictionary<string, float>? abilitySpecials;
        [JsonProperty] public readonly BaseAbilityMixin[]? abilityMixins;
        [JsonProperty] public readonly Dictionary<string, AbilityModifier>? modifiers;
        [JsonProperty] public readonly BaseAction[] onAdded;
        [JsonProperty] public readonly BaseAction[]? onAbilityStart;
        [JsonProperty] public readonly bool isDynamicAbility; // if true, disable this ability by default. Enable via ConfigTalent AddAbility     
    }
}
