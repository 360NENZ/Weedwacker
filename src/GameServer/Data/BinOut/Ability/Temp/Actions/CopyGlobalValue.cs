using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class CopyGlobalValue : BaseAction
    {
        [JsonProperty] public readonly string dstTarget;
        [JsonProperty] public readonly string srcKey;
        [JsonProperty] public readonly string dstKey;
    }
}
