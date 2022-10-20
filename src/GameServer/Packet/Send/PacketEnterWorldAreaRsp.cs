using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketEnterWorldAreaRsp : BasePacket
    {
        public PacketEnterWorldAreaRsp(Player player, uint areaId, uint areaType) : base(Enums.OpCode.EnterWorldAreaRsp)
        {
            EnterWorldAreaRsp p = new()
            {
                AreaId = areaId,
                AreaType = areaType
            };

            Data = p.ToByteArray();
        }
    }
}
