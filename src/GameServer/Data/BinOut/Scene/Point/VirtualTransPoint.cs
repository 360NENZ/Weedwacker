using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point
{
    internal class VirtualTransPoint : TransPoint
    {
        [JsonProperty] public readonly MarkIconType markIconTypeName;
    }
}
