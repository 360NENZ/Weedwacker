using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ModifyDamageMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] animEventNames;
        [JsonProperty] public readonly object? bonusCriticalHurt;
        [JsonProperty] public readonly object damagePercentageRatio;
    }
}
