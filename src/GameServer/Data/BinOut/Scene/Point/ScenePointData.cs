using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point
{
    internal class ScenePointData
    {
        [JsonProperty] public readonly Dictionary<string, BasePoint>? points;
    }
}
