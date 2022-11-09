using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetConfigID : BasePredicate
    {
        [JsonProperty] public readonly int[] configIdArray;
    }
}
