

using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketStoreItemChangeNotify : BasePacket
    {
        public PacketStoreItemChangeNotify(GameItem item) : base(OpCode.StoreItemChangeNotify)
        {

            StoreItemChangeNotify proto = new StoreItemChangeNotify()
            {
                StoreType = StoreType.Pack
            };
            proto.ItemList.Add(item.ToProto());

            Data = proto.ToByteArray();
        }

        public PacketStoreItemChangeNotify(IEnumerable<GameItem> items) : base(OpCode.StoreItemChangeNotify)
        {

            StoreItemChangeNotify proto = new StoreItemChangeNotify()
            {
                StoreType = StoreType.Pack
            };
            foreach (GameItem item in items)
            {
                proto.ItemList.Add(item.ToProto());
            }

            Data = proto.ToByteArray();
        }
    }
}
