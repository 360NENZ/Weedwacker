using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class SwitchSkillIDMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string priority;
        [JsonProperty] public readonly int skillIndex;
        [JsonProperty] public readonly int overtime;
    }
}
