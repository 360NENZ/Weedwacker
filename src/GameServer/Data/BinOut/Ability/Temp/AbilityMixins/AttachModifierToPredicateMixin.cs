using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachModifierToPredicateMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly AvatarEventType onEvent;
        [JsonProperty] public readonly BasePredicate[] predicates;
        [JsonProperty] public readonly string modifierName;
    }
}
