using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByEnergyRatio : BasePredicate
    {
        [JsonProperty] public readonly object ratio;
        [JsonProperty] public readonly LogicType logic;
    }
}
