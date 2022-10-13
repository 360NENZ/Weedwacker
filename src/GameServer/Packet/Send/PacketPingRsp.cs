using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPingRsp : BasePacket
    {
		public PacketPingRsp(uint clientSeq, uint time) : base(Enums.OpCode.PingRsp)
		{
			PingRsp p = new PingRsp()
			{
				ClientTime = time
			};

			Data = p.ToByteArray();
		}
	}
}
