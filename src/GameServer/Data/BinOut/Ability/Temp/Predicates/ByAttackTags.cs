using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByAttackTags : BasePredicate
    {
        [JsonProperty] public readonly string[] attackTags;
    }
}
