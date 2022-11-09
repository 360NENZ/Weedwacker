using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal class AbilityModifier
    {
        [JsonProperty] public readonly StackingType stacking;
        [JsonProperty] public readonly string modifierName;
        [JsonProperty] public readonly bool? isUnique;
        [JsonProperty] public readonly object duration;
        [JsonProperty] public readonly Dictionary<PropertyModifierType, object> properties;
        [JsonProperty] public readonly bool? isLimitedProperties;
        [JsonProperty] public readonly object elementDurability;
        [JsonProperty] public readonly object thinkInterval;
        [JsonProperty] public readonly BaseAbilityMixin[]? modifierMixins;
        [JsonProperty] public readonly BaseAction[]? onAdded;
        [JsonProperty] public readonly BaseAction[]? onRemoved;
        [JsonProperty] public readonly BaseAction[]? onBeingHit;
        [JsonProperty] public readonly BaseAction[]? onAttackLanded;
        [JsonProperty] public readonly BaseAction[]? onHittingOther;
        [JsonProperty] public readonly BaseAction[]? onThinkInterval;
        [JsonProperty] public readonly BaseAction[]? onKill;
        [JsonProperty] public readonly BaseAction[]? onCrash;
        [JsonProperty] public readonly BaseAction[]? onAvatarIn;
        [JsonProperty] public readonly BaseAction[]? onAvatarOut;
        [JsonProperty] public readonly BaseAction[]? onReconnect;
        [JsonProperty] public readonly BaseAction[]? onChangeAuthority;
        [JsonProperty] public readonly BaseAction[]? onVehicleIn;
        [JsonProperty] public readonly BaseAction[]? onVehicleOut;
        [JsonProperty] public readonly BaseAction[]? onZoneEnter;
        [JsonProperty] public readonly BaseAction[]? onZoneExit;
        [JsonProperty] public readonly BaseAction[]? onHeal;
        [JsonProperty] public readonly BaseAction[]? onBeingHealed;

        internal async Task Initialize(Dictionary<uint, IInvocation> localIdToInvocationMap)
        {
            // DO NOT CHANGE THE ORDER
            LocalIdGenerator idGenerator = new(ConfigAbilitySubContainerType.MODIFIER_ACTION);
            idGenerator.InitializeActionLocalIds(onAdded, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onRemoved, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onBeingHit, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onAttackLanded, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onHittingOther, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onThinkInterval, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onKill, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onCrash, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onAvatarIn, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onAvatarOut, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onReconnect, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onChangeAuthority, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onVehicleIn, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onVehicleOut, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onZoneEnter, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onZoneExit, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onHeal, localIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onBeingHealed, localIdToInvocationMap);
            idGenerator.ConfigIndex++;

            if (modifierMixins == null) return;
            idGenerator.Type = ConfigAbilitySubContainerType.MODIFIER_MIXIN;
            for (uint i = 0; i < modifierMixins.Length; i++)
            {
                idGenerator.ConfigIndex = 0;
                await modifierMixins[i].Initialize(idGenerator, localIdToInvocationMap);
                idGenerator.MixinIndex++;
            }
        }
    }
}
