using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ReviveElemEnergyMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float period;
        [JsonProperty] public readonly float baseEnergy;
        [JsonProperty] public readonly string ratio;
    }
}
