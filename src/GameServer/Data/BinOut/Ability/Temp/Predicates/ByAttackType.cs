using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByAttackType : BasePredicate
    {
        [JsonProperty] public readonly string attackType;
    }
}
