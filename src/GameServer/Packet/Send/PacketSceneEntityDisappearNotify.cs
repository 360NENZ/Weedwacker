using Google.Protobuf;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSceneEntityDisappearNotify : BasePacket
    {
		public PacketSceneEntityDisappearNotify(GameEntity entity, VisionType disappearType) : base(Enums.OpCode.SceneEntityDisappearNotify)
		{
			SceneEntityDisappearNotify proto = new SceneEntityDisappearNotify()
			{
				DisappearType = disappearType
			};
			proto.EntityList.Add(entity.Id);

			Data = proto.ToByteArray();
		}

		public PacketSceneEntityDisappearNotify(IEnumerable<GameEntity> entities, VisionType disappearType) : base(Enums.OpCode.SceneEntityDisappearNotify)
		{
			SceneEntityDisappearNotify proto = new SceneEntityDisappearNotify()
			{
				DisappearType = disappearType
			};

			entities.AsParallel().ForAll(w => proto.EntityList.Add(w.Id));

			Data = proto.ToByteArray();
		}
	}
}
