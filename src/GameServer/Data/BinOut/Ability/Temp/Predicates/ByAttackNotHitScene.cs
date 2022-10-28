using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByAttackNotHitScene : BasePredicate
    {
        [JsonProperty] public readonly BaseAttackPattern attackPattern;
    }
}
