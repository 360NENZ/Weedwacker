using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
	[OpCode((ushort)OpCode.PlayerSetPauseReq)]
	internal class HandlePlayerSetPauseReq : BaseHandler
    {
		public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
		{
			PacketHead head = PacketHead.Parser.ParseFrom(header);
			PlayerSetPauseReq req = PlayerSetPauseReq.Parser.ParseFrom(payload);

			await session.SendPacketAsync(new PacketPlayerSetPauseRsp(head.ClientSequenceId));
			session.Player.SetPaused(req.IsPaused);
	}
}
}
