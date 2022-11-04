using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class GlobalSubShieldMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string mainShieldModifierName;
    }
}
