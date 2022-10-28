using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.EventOps
{
    internal class ConfigAudioEventOp : BaseEventOp
    {
        [JsonProperty] public readonly Op operation;

        public class Op
        {
            [JsonProperty] public readonly string text;
        }
    }
}
