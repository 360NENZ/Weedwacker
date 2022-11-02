using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class Randomed : BaseAction
    {
        [JsonProperty] public readonly object chance;
        [JsonProperty] public readonly BaseAction[] successActions;
        [JsonProperty] public readonly BaseAction[] failActions;
    }
}
