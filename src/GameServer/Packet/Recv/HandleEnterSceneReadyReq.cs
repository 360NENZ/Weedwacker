using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.EnterSceneReadyReq)]
    internal class HandleEnterSceneReadyReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            EnterSceneReadyReq proto = EnterSceneReadyReq.Parser.ParseFrom(payload);
            // Reject player if invalid token
            if (session.Player.EnterSceneToken == proto.EnterSceneToken)
            {
                await session.Player.World.BroadcastPacketAsync(new PacketEnterScenePeerNotify(session.Player));

            }
            await session.SendPacketAsync(new PacketEnterSceneReadyRsp(session.Player, proto.EnterSceneToken));
        }
    }
}
