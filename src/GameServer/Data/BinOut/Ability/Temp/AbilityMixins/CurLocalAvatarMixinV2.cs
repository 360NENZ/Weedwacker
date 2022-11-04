using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class CurLocalAvatarMixinV2 : BaseAbilityMixin
    {
        [JsonProperty] public readonly string modifierName;
    }
}
