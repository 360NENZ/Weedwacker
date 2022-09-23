
using Weedwacker.GameServer.Data.Excel;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class MaterialItem : GameItem
    {
        public int Count;
        public new readonly MaterialData ItemData; 

        public MaterialItem(int ownerId) : base(ownerId)
        {

        }
    }
}
