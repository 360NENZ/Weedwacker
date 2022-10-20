using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSceneAreaWeatherNotify : BasePacket
    {
        public PacketSceneAreaWeatherNotify(ClimateType climateType, int weatherAreaId) : base(Enums.OpCode.SceneAreaWeatherNotify)
        {
            SceneAreaWeatherNotify p = new()
            {
                ClimateType = (uint)climateType,
                WeatherAreaId = (uint)weatherAreaId,
                /* TODO
                TransDuration = ,
                WeatherGadgetId = ,
                WeatherValueMap = ,
                */
            };

            Data = p.ToByteArray();
        }
    }
}
