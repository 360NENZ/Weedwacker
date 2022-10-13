using Google.Protobuf;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketWorldPlayerRTTNotify : BasePacket
    {
		public PacketWorldPlayerRTTNotify(World world) : base(Enums.OpCode.WorldPlayerRTTNotify)
		{ 
			WorldPlayerRTTNotify proto = new();

			proto.PlayerRttList.AddRange(world.Players.Select(p => new PlayerRTTInfo() { Uid = (uint)p.GameUid, Rtt = (uint)(p.Session.LastPingTime /1000) }));

			Data = proto.ToByteArray();
		}
	}
}
