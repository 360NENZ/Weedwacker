using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.SetOpenStateReq)]
    internal class HandleSetOpenStateReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            var req = SetOpenStateReq.Parser.ParseFrom(payload);
            uint openState = req.Key;
            uint value = req.Value;

            if (await session.Player.OpenStateManager.SetOpenStateFromClientAsync(openState, value))
                await session.SendPacketAsync(new PacketSetOpenStateRsp(openState, value));
            else
                await session.SendPacketAsync(new PacketSetOpenStateRsp(Retcode.RetFail));
        }
    }
}
