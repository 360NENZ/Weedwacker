using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetForwardAndSelfPosition : BasePredicate
    {
        [JsonProperty] public readonly LogicType logic;
        [JsonProperty] public readonly float value;
    }
}
