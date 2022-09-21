using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common
{
    public class FetterOpenCond
    {
        [JsonProperty]
        public readonly string condType;
        [JsonProperty]
        public readonly int[] paramList;
    }
}
