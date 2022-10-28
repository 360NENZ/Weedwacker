using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetHPRatio : BasePredicate
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly LogicType logic;
        [JsonProperty] public readonly object HPRatio; //TODO string or float
    }
}
