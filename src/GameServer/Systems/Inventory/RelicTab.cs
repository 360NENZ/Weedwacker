using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class RelicTab : InventoryTab
    {
        [BsonIgnore] public new const int InventoryLimit = 1500;
        [BsonElement] private int NextRelicId = 1; // Is it possible to collect this many items? O.o
        public new Dictionary<int, ReliquaryItem> Items = new(); // Mongodb unique (for the player) id
        public Dictionary<int, MaterialItem> UpgradeMaterials = new();

        public RelicTab(Player.Player owner, InventoryManager inventory) : base(owner, inventory) { }

        public override async Task OnLoadAsync(Player.Player owner, InventoryManager inventory)
        {
            Owner = owner;
            Inventory = inventory;
            foreach (ReliquaryItem item in Items.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
                if (item.EquippedAvatar != 0) await inventory.EquipRelic(owner.Avatars.Avatars[item.EquippedAvatar].Guid, item.Guid);
            }
            foreach (MaterialItem item in UpgradeMaterials.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
            }
        }

        internal override async Task<GameItem> AddItemAsync(int itemId, int count = 1)
        {
            if (GameData.ItemDataMap[itemId].itemType == ItemType.ITEM_MATERIAL)
            {
                if (UpgradeMaterials.TryGetValue(itemId, out MaterialItem material))
                {
                    if (material.ItemData.stackLimit >= material.Count + count)
                    {
                        material.Count += count;

                        // Update Database
                        var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                        var update = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_RELIQUARY}.UpgradeMaterials.{itemId}.Count", material.Count);
                        var result = await DatabaseManager.UpdateInventoryAsync(filter, update);

                        //TODO update codex
                        return material;
                    }
                    else return null;
                }
                else
                {
                    var newMaterial = new MaterialItem(Owner.GetNextGameGuid(), itemId, count);
                    UpgradeMaterials.Add(itemId, newMaterial);

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_RELIQUARY}.UpgradeMaterials.{itemId}", newMaterial);
                    var result = await DatabaseManager.UpdateInventoryAsync(filter, update);

                    //TODO update codex
                    return newMaterial;
                }
            }

            if (Items.Count == InventoryLimit)
            {
                return null;
            }

            var relic = new ReliquaryItem(Owner.GetNextGameGuid(), itemId, NextRelicId++);
            Items.Add(relic.UniqueId, relic);

            // Update Database
            var filter2 = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update2 = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_RELIQUARY}.Items.{relic.UniqueId}", relic);
            var result2 = await DatabaseManager.UpdateInventoryAsync(filter2, update2);

            //TODO update codex
            return relic;
        }

        internal override async Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            if (Items.TryGetValue((item as ReliquaryItem).UniqueId, out ReliquaryItem relic))
            {
                if (relic.EquippedAvatar != 0)
                {
                    await Owner.Avatars.Avatars[relic.EquippedAvatar].UnequipRelic(relic.ItemData.equipType);
                }

                // Update Database
                var filter2 = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var update2 = Builders<InventoryManager>.Update.Unset($"SubInventories.{ItemType.ITEM_RELIQUARY}.Items.{relic.UniqueId}");
                var result2 = await DatabaseManager.UpdateInventoryAsync(filter2, update2);

                Items.Remove(relic.UniqueId);
                return true;
            }
            else if (UpgradeMaterials.TryGetValue((item as MaterialItem).ItemId, out MaterialItem material))
            {
                if (material.Count - count >= 1)
                {
                    material.Count -= count;

                    // Update Database
                    var filter2 = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update2 = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_RELIQUARY}.UpgradeMaterials.{material.ItemId}.Count", material.Count);
                    var result2 = await DatabaseManager.UpdateInventoryAsync(filter2, update2);

                    return true;
                }
                else if (material.Count - count == 0)
                {
                    // Update Database
                    var filter2 = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update2 = Builders<InventoryManager>.Update.Unset($"SubInventories.{ItemType.ITEM_RELIQUARY}.Items.{material.ItemId}");
                    var result2 = await DatabaseManager.UpdateInventoryAsync(filter2, update2);

                    UpgradeMaterials.Remove(material.ItemId);
                    return true;
                }
                else
                {
                    Logger.WriteErrorLine("ItemId: " + item.ItemId + ". Tried to remove " + count + " have " + item.Count);
                    return false;
                }
            }
            else
            {
                Logger.WriteErrorLine("Tried to remove inexistent item");
                return false;
            }
        }
    }
}
