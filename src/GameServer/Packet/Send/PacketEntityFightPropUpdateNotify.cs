using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketEntityFightPropUpdateNotify : BasePacket
    {
		public PacketEntityFightPropUpdateNotify(GameEntity entity, FightProperty prop) : base(OpCode.EntityFightPropUpdateNotify)
		{
			EntityFightPropUpdateNotify proto = new EntityFightPropUpdateNotify()
			{
				EntityId = entity.Id
			};
			proto.FightPropMap.Add((uint)prop, entity.FightProps[prop]);

			Data = proto.ToByteArray();
		}

		public PacketEntityFightPropUpdateNotify(GameEntity entity, IEnumerable<FightProperty> props) : base(OpCode.EntityFightPropUpdateNotify)
		{
			EntityFightPropUpdateNotify proto = new EntityFightPropUpdateNotify()
			{
				EntityId = entity.Id
			};
			props.AsParallel().ForAll(w => proto.FightPropMap.Add((uint)w, entity.FightProps[w]));

			Data = proto.ToByteArray();
		}
	}
}
