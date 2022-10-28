using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class KillSelf : BaseAction
    {
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
