using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point
{
    internal abstract class BasePoint
    {
        [JsonProperty] public readonly int gadgetId;
        [JsonProperty] public readonly int areaId;
        [JsonProperty] public readonly Dictionary<string, float> pos;
        [JsonProperty] public readonly Dictionary<string, float> rot;
        [JsonProperty] public readonly Dictionary<string, float> tranPos;
        [JsonProperty] public readonly Dictionary<string, float> tranRot;
        [JsonProperty] public readonly string? alias;
    }
}
