using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.QueryPathReq)]
    internal class HandleQueryPathReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            var req = QueryPathReq.Parser.ParseFrom(payload);

            /**
             * It is not the actual work
             */

            if (req.DestinationPos.Count > 0)
            {
                await session.SendPacketAsync(new PacketQueryPathRsp(req));
            }
        }
    }
}
