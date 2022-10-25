using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.TowerAllDataReq)]
    internal class HandleTowerAllDataReq : BaseHandler
    {
        //TODO
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            await session.SendPacketAsync(new PacketTowerAllDataRsp());
        }
    }
}
