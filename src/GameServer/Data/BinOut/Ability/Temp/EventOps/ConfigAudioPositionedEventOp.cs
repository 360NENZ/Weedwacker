using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.EventOps
{
    internal class ConfigAudioPositionedEventOp : BaseEventOp
    {
        [JsonProperty] public readonly float positioning;
        [JsonProperty] public readonly float duration;
    }
}
