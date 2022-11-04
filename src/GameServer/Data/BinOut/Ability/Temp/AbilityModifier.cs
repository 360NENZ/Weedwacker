using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal class AbilityModifier
    {
        [JsonProperty] public readonly StackingType stacking;
        [JsonProperty] public readonly string modifierName;
        [JsonProperty] public readonly bool? isUnique;
        [JsonProperty] public readonly Dictionary<PropertyModifierType, object> properties;
        [JsonProperty] public readonly bool? isLimitedProperties;
        [JsonProperty] public readonly object elementDurability;
        [JsonProperty] public readonly BaseAbilityMixin[]? modifierMixins;
        [JsonProperty] public readonly BaseAction[]? onAdded;
        [JsonProperty] public readonly BaseAction[]? onRemoved;
    }
}
