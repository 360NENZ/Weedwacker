using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.GetPlayerSocialDetailReq)]
    internal class HandleGetPlayerSocialDetailReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            GetPlayerSocialDetailReq req = GetPlayerSocialDetailReq.Parser.ParseFrom(payload);

            SocialDetail? detail = await GameServer.GetSocialDetailByUid(session.Player.GameUid, req.Uid);
            await session.SendPacketAsync(new PacketGetPlayerSocialDetailRsp(detail));
        }
    }
}
