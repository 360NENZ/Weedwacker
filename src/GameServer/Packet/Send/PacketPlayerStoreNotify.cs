using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPlayerStoreNotify : BasePacket
    {
        public PacketPlayerStoreNotify(Player player) : base(Enums.OpCode.PlayerStoreNotify)
        {
            BuildHeader(2);

            PlayerStoreNotify p = new PlayerStoreNotify()
            {
                StoreType = StoreType.Pack,
                WeightLimit = 30000
            };

            foreach (var item in player.Inventory.GuidMap.Values)
            {
                Item itemProto = item.ToProto();
                p.ItemList.Add(itemProto);
            }

            Data = p.ToByteArray();
        }
    }
}
