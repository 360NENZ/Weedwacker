using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class TriggerPostProcessEffectMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string postEffectAssetName;
        [JsonProperty] public readonly float duration;
    }
}
