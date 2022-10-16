using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common
{
    internal class BornPos
    {
        [JsonProperty] public readonly int _id;
        [JsonProperty] public readonly int _configId;
        [JsonProperty] public readonly Dictionary<string, float> _pos;
        [JsonProperty] public readonly Dictionary<string, float> _rot;
        [JsonProperty] public readonly int _groupId;
        [JsonProperty] public readonly int[] _suiteIdList;
    }
}
