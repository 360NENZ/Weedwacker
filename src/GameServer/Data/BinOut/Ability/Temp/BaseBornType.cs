using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal abstract class BaseBornType
    {
        [JsonProperty] public readonly OffSet? offset;
        public class OffSet
        {
            [JsonProperty] public readonly float x;
            [JsonProperty] public readonly float y;
            [JsonProperty] public readonly float z;
        }
    }
}
