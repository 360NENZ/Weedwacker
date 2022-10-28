using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByCurTeamHasFeatureTag : BasePredicate
    {
        [JsonProperty] public readonly int featureTagID;
        [JsonProperty] public readonly LogicType logic;
    }
}
