using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ApplyInertiaVelocityMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float damping;
        [JsonProperty] public readonly bool useXZ;
        [JsonProperty] public readonly bool useY;
    }
}
