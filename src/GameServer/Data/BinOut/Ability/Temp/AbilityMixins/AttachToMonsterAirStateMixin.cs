using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToMonsterAirStateMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string modifierName;
        [JsonProperty] public readonly bool IsAirMove;
    }
}
