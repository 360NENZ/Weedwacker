using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarSkillChangeNotify : BasePacket
    {
		public PacketAvatarSkillChangeNotify(Avatar avatar, int depotId, int skillId, int oldLevel, int curLevel) : base(OpCode.AvatarSkillChangeNotify)
		{
			AvatarSkillChangeNotify proto = new AvatarSkillChangeNotify()
			{
				AvatarGuid = avatar.Guid,
				EntityId = (uint)avatar.EntityId,
				SkillDepotId = (uint)depotId,
				AvatarSkillId = (uint)skillId,
				OldLevel = (uint)oldLevel,
				CurLevel = (uint)curLevel
			};

			Data = proto.ToByteArray();
		}
	}
}
