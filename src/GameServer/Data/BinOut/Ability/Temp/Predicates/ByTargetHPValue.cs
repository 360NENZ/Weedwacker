using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetHPValue : BasePredicate
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly LogicType logic;
        [JsonProperty] public readonly float HP;
    }
}
