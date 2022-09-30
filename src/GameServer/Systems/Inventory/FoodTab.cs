
namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class FoodTab : MaterialsTab
    {
        public new readonly int InventoryLimit = 2000;

        internal override Task<GameItem> AddItemAsync(int itemId, int count = 1)
        {
            throw new NotImplementedException();
        }
    }
}
