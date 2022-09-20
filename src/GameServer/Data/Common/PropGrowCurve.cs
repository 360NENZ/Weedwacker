using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common
{
    internal class PropGrowCurve
    {
        [JsonProperty]
        public readonly string type;
        [JsonProperty]
        public readonly string growCurve;
    }
}
