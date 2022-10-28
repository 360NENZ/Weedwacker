using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AvatarChangeSkillMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string priority;
        [JsonProperty] public readonly int jumpSkillID;
        [JsonProperty] public readonly int flySkillID;
    }
}
