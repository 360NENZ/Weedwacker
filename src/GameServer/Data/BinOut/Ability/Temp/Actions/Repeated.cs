using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class Repeated : BaseAction
    {
        [JsonProperty] public readonly string repeatTimes;
        [JsonProperty] public readonly BaseAction[] actions;
    }
}
