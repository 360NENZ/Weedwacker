using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode("PlayerLoginReq")]
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

            // Show opening cutscene if player has no avatars
            if (session.Player.Avatars.GetAvatarCount() == 0)
            {
                // Pick character
                session.State = SessionState.PICKING_CHARACTER;
                await session.SendPacketAsync(new BasePacket(OpCode.DoSetPlayerBornDataNotify));
            }
            else
            {
                // Login done
                session.Player.OnLogin();
            }

            // Final packet to tell client logging in is done
            await session.SendPacketAsync(new PacketPlayerLoginRsp(session));
        }
    
    }
}
