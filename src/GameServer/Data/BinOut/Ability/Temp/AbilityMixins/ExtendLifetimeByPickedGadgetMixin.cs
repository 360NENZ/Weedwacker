using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ExtendLifetimeByPickedGadgetMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int[] pickedConfigIDs;
        [JsonProperty] public readonly string extendLifeTime;
        [JsonProperty] public readonly string maxExtendLifeTime;
    }
}
