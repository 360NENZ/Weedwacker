using Google.Protobuf;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketStoreWeightLimitNotify : BasePacket
    {
        public PacketStoreWeightLimitNotify() : base(Enums.OpCode.StoreWeightLimitNotify)
        {
            StoreWeightLimitNotify p = new StoreWeightLimitNotify()
            {
                StoreType = StoreType.Pack,
                WeightLimit = 30000,
                WeaponCountLimit = WeaponTab.InventoryLimit,
                ReliquaryCountLimit = RelicTab.InventoryLimit,
                MaterialCountLimit = MaterialsTab.InventoryLimit,
                FurnitureCountLimit = FurnitureTab.InventoryLimit

            };

            Data = p.ToByteArray();
        }
    }
}
