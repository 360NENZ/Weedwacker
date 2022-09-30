
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class MaterialItem : GameItem
    {
        public int Count;
        public new readonly MaterialData ItemData; 

        public MaterialItem(int ownerId) : base(ownerId)
        {

        }

        public override Item ToProto()
        {
            throw new NotImplementedException();
        }
    }
}
