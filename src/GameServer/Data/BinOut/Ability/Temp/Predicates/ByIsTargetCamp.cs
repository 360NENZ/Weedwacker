using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByIsTargetCamp : BasePredicate
    {
        [JsonProperty] public readonly string campBaseOn;
        [JsonProperty] public readonly TargetType campTargetType;
    }
}
