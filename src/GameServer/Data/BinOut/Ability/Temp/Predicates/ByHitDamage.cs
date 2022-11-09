using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHitDamage : BasePredicate
    {
        [JsonProperty] public readonly float damage;
    }
}
