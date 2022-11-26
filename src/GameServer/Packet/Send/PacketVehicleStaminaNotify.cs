using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketVehicleStaminaNotify : BasePacket
    {
        public PacketVehicleStaminaNotify(uint vehicleId, float newStamina) : base(Enums.OpCode.VehicleStaminaNotify)
        {
            VehicleStaminaNotify proto = new VehicleStaminaNotify()
            {
                EntityId = vehicleId,
                CurStamina = newStamina
            };

            Data = proto.ToByteArray();
        }
    }
}
