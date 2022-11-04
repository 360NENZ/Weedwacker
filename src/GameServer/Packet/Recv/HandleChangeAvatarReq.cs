using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.ChangeAvatarReq)]
    internal class HandleChangeAvatarReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            ChangeAvatarReq req = ChangeAvatarReq.Parser.ParseFrom(payload);
            await session.Player.TeamManager.ChangeAvatar(req.Guid);
            await session.SendPacketAsync(new PacketChangeAvatarRsp(req.Guid));
        }
    }
}
