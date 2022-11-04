using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ServerUpdateGlobalValueMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string key;
    }
}
