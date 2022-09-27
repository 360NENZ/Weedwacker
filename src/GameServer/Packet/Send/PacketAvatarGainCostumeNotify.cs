using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarGainCostumeNotify : BasePacket
    {
		public PacketAvatarGainCostumeNotify(int costumeId) : base(Enums.OpCode.AvatarGainCostumeNotify)
		{
			AvatarGainCostumeNotify proto = new AvatarGainCostumeNotify() { CostumeId = (uint)costumeId };

			Data = proto.ToByteArray();
		}
	}
}
