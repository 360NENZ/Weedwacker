using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.PlayerLoginReq)]
    internal class HandlePlayerLoginReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            // Check
            if (session.Player == null)
            {
                session.Stop();
                return;
            }

            // Parse request
            PlayerLoginReq req = PlayerLoginReq.Parser.ParseFrom(payload);

            // Authenticate session
            if (req.Token != session.Player.Token)
            {
                session.Stop();
                return;
            }

            // Login Setup
            await session.Player.OnLoginAsync();


            // Final packet to tell client logging in is done
            await session.SendPacketAsync(new PacketPlayerLoginRsp(session));
        }

    }
}
