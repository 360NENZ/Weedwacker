using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.PingReq)]
    internal class HandlePingReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            PacketHead head = PacketHead.Parser.ParseFrom(header);
            PingReq ping = PingReq.Parser.ParseFrom(payload);

            session.UpdateLastPingTime(ping.ClientTime);

            await session.SendPacketAsync(new PacketPingRsp(head.ClientSequenceId, ping.ClientTime));
        }
    }
}
