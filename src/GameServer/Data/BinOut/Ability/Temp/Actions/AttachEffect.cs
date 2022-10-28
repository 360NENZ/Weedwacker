using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AttachEffect : BaseAction
    {
        [JsonProperty] public readonly string effectPattern;
    }
}
