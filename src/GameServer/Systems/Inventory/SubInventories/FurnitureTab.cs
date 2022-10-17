using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class FurnitureTab : InventoryTab
    {
        [BsonIgnore] public new const int InventoryLimit = 2000;
        [BsonSerializer(typeof(IntDictionarySerializer<MaterialItem>))]
        public Dictionary<int, MaterialItem> Materials = new(); // ItemId

        public FurnitureTab(Player.Player owner, InventoryManager inventory) : base(owner, inventory) { }

        public override async Task OnLoadAsync(Player.Player owner, InventoryManager inventory)
        {
            Owner = owner;
            Inventory = inventory;
            foreach (FurnitureItem item in Items.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
            }
            foreach (MaterialItem item in Materials.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
            }
        }

        //TODO FurnitureItem
        internal override async Task<GameItem?> AddItemAsync(int itemId, int count = 1)
        {

            if (GameData.ItemDataMap[itemId].itemType == ItemType.ITEM_MATERIAL)
            {
                if (Materials.TryGetValue(itemId, out MaterialItem? material))
                {
                    if (material.ItemData.stackLimit >= material.Count + count)
                    {
                        material.Count += count;

                        // Update Database
                        var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                        var update = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_FURNITURE}.Materials.{itemId}.Count", material.Count);
                        await DatabaseManager.UpdateInventoryAsync(filter, update);

                        //TODO update codex
                        return material;
                    }
                    else return null;
                }
                else
                {
                    var newMaterial = new MaterialItem(Owner.GetNextGameGuid(), itemId, count);
                    Materials.Add(itemId, newMaterial);

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_FURNITURE}.Materials.{itemId}", newMaterial);
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    //TODO update codex
                    return newMaterial;
                }
            }

            //TODO Furniture
            return null;
        }

        //TODO FurnitureItem
        internal override async Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            if (Materials.TryGetValue((item as MaterialItem).ItemId, out MaterialItem? material))
            {
                if (material.Count - count >= 1)
                {
                    material.Count -= count;

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_FURNITURE}.Materials.{material.ItemId}.Count", material.Count);
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    return true;
                }
                else if (material.Count - count == 0)
                {
                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Unset($"SubInventories.{ItemType.ITEM_FURNITURE}.Materials.{material.ItemId}");
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    Materials.Remove(material.ItemId);
                    return true;
                }
                else
                {
                    Logger.WriteErrorLine("ItemId: " + item.ItemId + ". Tried to remove " + count + " have " + item.Count);
                    return false;
                }
            }
            else if (item.ItemData.itemType == ItemType.ITEM_FURNITURE)
            {
                Logger.WriteErrorLine("Furniture not implemented yet :(");
                return false;
            }
            else
            {
                Logger.WriteErrorLine("Tried to remove inexistent item");
                return false;
            }
        }
    }
}
