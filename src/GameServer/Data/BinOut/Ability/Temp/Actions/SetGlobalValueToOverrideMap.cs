using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetGlobalValueToOverrideMap : BaseAction
    {
        [JsonProperty] public readonly string globalValueKey;
        [JsonProperty] public readonly string overrideMapKey;
    }
}
