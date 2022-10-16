using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point
{
    internal class SceneBuildingPoint : BasePoint
    {
        [JsonProperty] public readonly BuildingType buildingType;
    }
}
