using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarLifeStateChangeNotify : BasePacket
    {
		public PacketAvatarLifeStateChangeNotify(Avatar avatar, PlayerDieType dieType = PlayerDieType.None,
			SceneEntity? sourceEntity = null, string attackTag = "") : base(OpCode.AvatarLifeStateChangeNotify)
		{
			AvatarLifeStateChangeNotify proto = new()
			{
				AvatarGuid = avatar.Guid,
				LifeState = (uint)avatar.LifeState,
				DieType = dieType,
				AttackTag = attackTag
			};

			if (sourceEntity != null)
			{
				proto.SourceEntityId = sourceEntity.EntityId;
			}

			Data = proto.ToByteArray();
		}
	}
}
