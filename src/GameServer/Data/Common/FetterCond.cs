using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Common
{
    public class FetterCond
    {
        [JsonProperty]
        public readonly FetterCondType condType;
        [JsonProperty]
        public readonly int[] paramList;
    }
}
