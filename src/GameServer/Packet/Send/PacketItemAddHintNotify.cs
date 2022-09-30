using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketItemAddHintNotify : BasePacket
    {
		public PacketItemAddHintNotify(GameItem item, ActionReason reason) : base(OpCode.ItemAddHintNotify)
		{

			ItemAddHintNotify proto = new()
			{
				Reason = (uint)reason
			};
			proto.ItemList.Add(item.ToItemHintProto());

			Data = proto.ToByteArray();
		}

		public PacketItemAddHintNotify(IEnumerable<GameItem> items, ActionReason reason) : base(OpCode.ItemAddHintNotify)
		{

			ItemAddHintNotify proto = new()
			{
				Reason = (uint)reason
			};

			foreach (GameItem item in items)
			{
				proto.ItemList.Add(item.ToItemHintProto());
			}

			Data = proto.ToByteArray();
		}
	}
}
