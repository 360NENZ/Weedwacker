using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarFlycloakChangeNotify : BasePacket
    {
		public PacketAvatarFlycloakChangeNotify(Database.Avatar avatar) : base(OpCode.AvatarFlycloakChangeNotify)
		{
			AvatarFlycloakChangeNotify proto = new()
			{
				AvatarGuid = (uint)avatar.Guid,
				FlycloakId = (uint)avatar.FlyCloak
			};
			Data = proto.ToByteArray();
		}
	}
}
