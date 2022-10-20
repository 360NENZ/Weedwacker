using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.GetSceneAreaReq)]
    internal class HandleGetSceneAreaReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            GetSceneAreaReq req = GetSceneAreaReq.Parser.ParseFrom(payload);
            await session.SendPacketAsync(new PacketGetSceneAreaRsp(session.Player, req.SceneId));
        }
    }
}
