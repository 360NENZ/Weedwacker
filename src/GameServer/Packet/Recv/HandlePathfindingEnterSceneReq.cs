using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.PathfindingEnterSceneReq)]
    internal class HandlePathfindingEnterSceneReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            PacketHead head = PacketHead.Parser.ParseFrom(header);
            PathfindingEnterSceneReq req = PathfindingEnterSceneReq.Parser.ParseFrom(payload);
            await session.SendPacketAsync(new PacketPathfindingEnterSceneRsp(head.ClientSequenceId));
        }
    }
}
