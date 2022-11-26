using Google.Protobuf;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketStoreItemDelNotify : BasePacket
    {
        public PacketStoreItemDelNotify(GameItem item) : base(Enums.OpCode.StoreItemDelNotify)
        {
            StoreItemDelNotify proto = new()
            {
                StoreType = StoreType.Pack
            };
            proto.GuidList.Add((ulong)item.Guid);

            Data = proto.ToByteArray();
        }

        public PacketStoreItemDelNotify(IEnumerable<GameItem> items) : base(Enums.OpCode.StoreItemDelNotify)
        {
            StoreItemDelNotify proto = new()
            {
                StoreType = StoreType.Pack
            };
            foreach (GameItem item in items)
            {
                proto.GuidList.Add((ulong)item.Guid);
            }

            Data = proto.ToByteArray();
        }
    }
}
