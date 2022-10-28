using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class FireSubEmitterEffect : BaseAction
    {
        [JsonProperty] public readonly string effectPattern;
        [JsonProperty] public readonly BaseBornType born;
    }
}
