using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.PlayerForceExitReq)]
    internal class HandlePlayerForceExitReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            await session.SendPacketAsync(new BasePacket(OpCode.PlayerForceExitRsp));
            session.Stop();
        }
    }
}
