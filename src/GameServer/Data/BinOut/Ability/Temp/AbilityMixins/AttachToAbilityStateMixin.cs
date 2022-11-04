using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToAbilityStateMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly AbilityState[] abilityStates;
        [JsonProperty] public readonly string modifierName;
    }
}
