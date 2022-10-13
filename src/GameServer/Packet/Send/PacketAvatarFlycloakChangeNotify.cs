using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarFlycloakChangeNotify : BasePacket
    {
		public PacketAvatarFlycloakChangeNotify(Avatar avatar) : base(OpCode.AvatarFlycloakChangeNotify)
		{
			AvatarFlycloakChangeNotify proto = new()
			{
				AvatarGuid = avatar.Guid,
				FlycloakId = (uint)avatar.FlyCloak
			};
			Data = proto.ToByteArray();
		}
	}
}
