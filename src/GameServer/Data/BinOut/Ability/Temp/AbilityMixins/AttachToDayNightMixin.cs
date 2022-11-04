using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToDayNightMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string time;
        [JsonProperty] public readonly string modifierName;
    }
}
