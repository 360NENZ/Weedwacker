using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnablePartControl : BaseAction
    {
        [JsonProperty] public readonly string[] partRootNames;
        [JsonProperty] public readonly bool enable;
    }
}
