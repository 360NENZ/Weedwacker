
using MongoDB.Bson;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal abstract class InventoryTab : SubInventory
    {
        public readonly int InventoryLimit = 9999;
        public Dictionary<ObjectId, GameItem> Items;

        //TODO update codex

        
    }
}
