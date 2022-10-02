
using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    // Precious Items
    internal class PreciousTab : MaterialsTab
    {
        [BsonIgnore] public new const int InventoryLimit = 9999;
        public new Dictionary<int, MaterialItem> Items = new();

        public PreciousTab(Player.Player owner, InventoryManager inventory) : base(owner, inventory) { }

        internal override async Task<GameItem?> AddItemAsync(int itemId, int count = 1)
        {
            if (Items.TryGetValue(itemId, out MaterialItem material))
            {
                if (material.ItemData.stackLimit >= material.Count + count)
                {
                    material.Count += count;

                    // Update Database
                    var updateQuery = new UpdateQueryBuilder<InventoryManager>();
                    updateQuery.SetFilter(w => w.OwnerId == Owner.GameUid);
                    updateQuery.AddValueToSet(w =>
                        (w.SubInventories[ItemType.ITEM_MATERIAL] as MaterialSubInv).PreciousTab.Items[itemId].Count, material.Count);
                    var queryStrings = updateQuery.Build();
                    await DatabaseManager.UpdateInventoryAsync(queryStrings);

                    //TODO update codex
                    return material;
                }
                else return null;
            }
            else
            {
                var newMaterial = new MaterialItem(Owner.GetNextGameGuid(), itemId, count);
                Items.Add(itemId, newMaterial);

                // Update Database
                var updateQuery = new UpdateQueryBuilder<InventoryManager>();
                updateQuery.SetFilter(w => w.OwnerId == Owner.GameUid);
                updateQuery.AddValueToSet(w =>
                    (w.SubInventories[ItemType.ITEM_MATERIAL] as MaterialSubInv).PreciousTab.Items[itemId], newMaterial);
                var queryStrings = updateQuery.Build();
                await DatabaseManager.UpdateInventoryAsync(queryStrings);

                //TODO update codex
                return newMaterial;
            }
        }

        internal override async Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            if (Items.TryGetValue((item as MaterialItem).ItemId, out MaterialItem material))
            {
                if (material.Count - count >= 1)
                {
                    material.Count -= count;

                    // Update Database
                    var updateQueryMat = new UpdateQueryBuilder<InventoryManager>();
                    updateQueryMat.SetFilter(w => w.OwnerId == Owner.GameUid);
                    updateQueryMat.AddValueToSet(w =>
                        (w.SubInventories[ItemType.ITEM_MATERIAL] as MaterialSubInv).PreciousTab.Items[material.ItemId].Count, material.Count);
                    var queryStringsMat = updateQueryMat.Build();
                    await DatabaseManager.UpdateInventoryAsync(queryStringsMat);

                    return true;
                }
                else if (material.Count - count == 0)
                {
                    // Update Database
                    var updateQueryMat = new UpdateQueryBuilder<InventoryManager>();
                    updateQueryMat.SetFilter(w => w.OwnerId == Owner.GameUid);
                    updateQueryMat.AddValueToUnSet(w =>
                        (w.SubInventories[ItemType.ITEM_MATERIAL] as MaterialSubInv).PreciousTab.Items[material.ItemId], material);
                    var queryStringsMat = updateQueryMat.Build();
                    await DatabaseManager.UpdateInventoryAsync(queryStringsMat);

                    Items.Remove(material.ItemId);
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
