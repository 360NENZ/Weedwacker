namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class BattlePassTab : InventoryTab
    {
        internal override Task<GameItem?> AddItemAsync(int itemId, int count = 1)
        {
            throw new NotImplementedException();
        }

        internal override Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            throw new NotImplementedException();
        }
    }
}
