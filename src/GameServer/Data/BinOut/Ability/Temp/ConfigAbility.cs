using System.Runtime.Serialization;
using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal class ConfigAbility : BaseConfigAbility
    {
        [JsonProperty] public readonly string abilityName;
        [JsonProperty] public readonly Dictionary<string, float>? abilitySpecials;
        [JsonProperty] public readonly BaseAbilityMixin[]? abilityMixins;
        [JsonProperty] public readonly Dictionary<string, AbilityModifier>? modifiers;
        [JsonProperty] public readonly BaseAction[]? onAdded;
        [JsonProperty] public readonly BaseAction[]? onRemoved;
        [JsonProperty] public readonly BaseAction[]? onAbilityStart;
        [JsonProperty] public readonly BaseAction[]? onKill;
        [JsonProperty] public readonly BaseAction[]? onFieldEnter;
        [JsonProperty] public readonly BaseAction[]? onExit;
        [JsonProperty] public readonly BaseAction[]? onAttach;
        [JsonProperty] public readonly BaseAction[]? onDetach;
        [JsonProperty] public readonly BaseAction[]? onAvatarIn;
        [JsonProperty] public readonly BaseAction[]? onAvatarOut;
        [JsonProperty] public readonly BaseAction[]? onTriggerAvatarRay;
        [JsonProperty] public readonly BaseAction[]? onVehicleIn;
        [JsonProperty] public readonly BaseAction[]? onVehicleOut;
        [JsonProperty] public readonly bool isDynamicAbility; // if true, disable this ability by default. Enable via ConfigTalent AddAbility     

        [JsonIgnore] public Dictionary<uint, IInvocation> LocalIdToInvocationMap;
        [JsonIgnore] public SortedList<uint, AbilityModifier> ModifierList;

        [OnDeserialized]
        internal async void OnDeserializedMethod(StreamingContext context)
        {
            // DO NOT CHANGE THE ORDER
            LocalIdToInvocationMap = new();

            LocalIdGenerator idGenerator = new(ConfigAbilitySubContainerType.ACTION);
            idGenerator.InitializeActionLocalIds(onAdded, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onRemoved, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onAbilityStart, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onKill, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onFieldEnter, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onExit, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onAttach, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onDetach, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onAvatarIn, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onAvatarOut, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onTriggerAvatarRay, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onVehicleIn, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onVehicleOut, LocalIdToInvocationMap);

            if (modifiers != null)
            {
                ModifierList = new();
                var modifierArray = modifiers.ToArray();
                for (uint i = 0; i < modifierArray.Length; i++)
                {
                    ModifierList[i] = modifierArray[i].Value;
                    await modifierArray[i].Value.Initialize(LocalIdToInvocationMap);
                }
            }

            if (abilityMixins != null)
            {
                LocalIdGenerator idGenerator2 = new(ConfigAbilitySubContainerType.MIXIN);
                for (uint i = 0; i < abilityMixins.Length; i++)
                {
                    idGenerator2.ConfigIndex = 0;
                    await abilityMixins[i].Initialize(idGenerator2, LocalIdToInvocationMap);
                    idGenerator2.MixinIndex++;
                }
            }
        }
    }
}
