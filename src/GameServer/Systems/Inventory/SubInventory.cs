namespace Weedwacker.GameServer.Systems.Inventory
{
    internal abstract class SubInventory
    {
        // Add item Guid to the GuidMap if not already there
        // return null if no update item
        internal abstract Task<GameItem?> AddItemAsync(int itemId, int count = 1);

        internal abstract Task<bool> RemoveItemAsync(GameItem item, int count = 1);
    }
}
