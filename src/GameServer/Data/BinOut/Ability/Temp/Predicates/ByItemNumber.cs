using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByItemNumber : BasePredicate
    {
        [JsonProperty] public readonly int itemId;
        [JsonProperty] public readonly int itemNum;
    }
}
