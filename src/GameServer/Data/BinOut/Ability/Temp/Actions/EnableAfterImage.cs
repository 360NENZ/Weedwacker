using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnableAfterImage : BaseAction
    {
        [JsonProperty] public readonly bool? enable;
        [JsonProperty] public readonly bool? doOffStage;
    }
}
