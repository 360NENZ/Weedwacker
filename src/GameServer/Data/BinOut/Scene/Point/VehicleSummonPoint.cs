using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point
{
    internal class VehicleSummonPoint : BasePoint
    {
        [JsonProperty] public readonly VehicleType vehicleType;
    }
}
