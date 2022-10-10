using Weedwacker.GameServer.Data.Excel;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class MaterialItem : GameItem
    {
        public int Count;
        public new readonly MaterialData ItemData; 

        public MaterialItem(ulong guid, int itemId, int count) : base(guid, itemId, count)
        {

        }

        public override Item ToProto()
        {
            Item proto = new()
            {
                Guid = Guid,
                ItemId = (uint)ItemData.id,
                Material = new() { Count = (uint)Count}
            };

            return proto;
        }
    }
}
