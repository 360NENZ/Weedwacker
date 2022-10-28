using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHasChildGadget : BasePredicate
    {
        [JsonProperty] public readonly int[] configIdArray;
        [JsonProperty] public readonly string compareType;
    }
}
