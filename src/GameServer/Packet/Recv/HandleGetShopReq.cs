using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.GetShopReq)]
    internal class HandleGetShopReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            GetShopReq req = GetShopReq.Parser.ParseFrom(payload);
            await session.SendPacketAsync(new PacketGetShopRsp(session.Player, req.ShopType));
        }
    }
}
