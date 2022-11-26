using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class RejectAttackMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string attackTag;
    }
}
