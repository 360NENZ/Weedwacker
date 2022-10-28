using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByEntityTypes : BasePredicate
    {
        [JsonProperty] public readonly EntityType[] entityTypes;
    }
}
