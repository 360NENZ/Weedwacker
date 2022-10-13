using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarFightPropNotify : BasePacket
    {
		public PacketAvatarFightPropNotify(Avatar avatar) : base(OpCode.AvatarFightPropNotify)
		{
			AvatarFightPropNotify proto = new AvatarFightPropNotify()
			{
				AvatarGuid = avatar.Guid
			};
			foreach(FightProperty prop in avatar.FightProp.Keys)
            {
				proto.FightPropMap.Add((uint)prop,avatar.FightProp[prop]);
            }

			Data = proto.ToByteArray();
		}
	}
}
