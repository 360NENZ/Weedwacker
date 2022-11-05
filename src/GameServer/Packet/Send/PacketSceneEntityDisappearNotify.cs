using Google.Protobuf;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSceneEntityDisappearNotify : BasePacket
    {
		public PacketSceneEntityDisappearNotify(SceneEntity entity, VisionType disappearType) : base(Enums.OpCode.SceneEntityDisappearNotify)
		{
			SceneEntityDisappearNotify proto = new SceneEntityDisappearNotify()
			{
				DisappearType = disappearType
			};
			proto.EntityList.Add(entity.EntityId);

			Data = proto.ToByteArray();
		}

		public PacketSceneEntityDisappearNotify(IEnumerable<SceneEntity> entities, VisionType disappearType) : base(Enums.OpCode.SceneEntityDisappearNotify)
		{
			SceneEntityDisappearNotify proto = new SceneEntityDisappearNotify()
			{
				DisappearType = disappearType
			};

			entities.AsParallel().ForAll(w => proto.EntityList.Add(w.EntityId));

			Data = proto.ToByteArray();
		}
	}
}
