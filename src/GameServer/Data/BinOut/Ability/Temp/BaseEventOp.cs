using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal abstract class BaseEventOp
    {
        [JsonProperty] public readonly Operation operation;

        public class Operation
        {
            [JsonProperty] public readonly string text;
        }
    }
}
