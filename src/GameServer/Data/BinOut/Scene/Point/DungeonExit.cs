using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point
{
    internal class DungeonExit : BasePoint
    {
        [JsonProperty] public readonly int entryPointId;
    }
}
