using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point
{
    internal class SceneVehicleSummonPoint : BasePoint
    {
        [JsonProperty] public readonly VehicleType vehicleType;
        [JsonProperty] public readonly int vehicleGadgetId;
        [JsonProperty] public readonly List<Dictionary<string, float>> bornPointList;
        [JsonProperty] public readonly List<Dictionary<string, float>> bornRotateList;
        [JsonProperty] public readonly float vehicleRadius;
    }
}
