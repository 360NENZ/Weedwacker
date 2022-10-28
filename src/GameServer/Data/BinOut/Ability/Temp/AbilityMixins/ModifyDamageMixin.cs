using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ModifyDamageMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] animEventNames;
        [JsonProperty] public readonly object bonusCriticalHurt; //TODO string or string[] -_-
        [JsonProperty] public readonly object damagePercentageRatio; //TODO float or string
    }
}
