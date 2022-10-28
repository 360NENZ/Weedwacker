using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class BySkillReady : BasePredicate
    {
        [JsonProperty] public readonly int overtime;
    }
}
