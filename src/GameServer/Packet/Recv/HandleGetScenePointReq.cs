using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.GetScenePointReq)]
    internal class HandleGetScenePointReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            GetScenePointReq req = GetScenePointReq.Parser.ParseFrom(payload);
            await session.SendPacketAsync(new PacketGetScenePointRsp(session.Player, req.SceneId));
        }
    }
}
