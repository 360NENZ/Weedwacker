using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class DebugLog : BaseAction
    {
        [JsonProperty] public readonly string content;
    }
}
