using MongoDB.Bson.Serialization.Attributes;
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
        public new Dictionary<int, FurnitureItem> Items = new(); // ItemId
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

        internal override async Task<GameItem> AddItemAsync(int itemId, int count = 1)
        {

            if (GameData.ItemDataMap[itemId].itemType == ItemType.ITEM_MATERIAL)
            {
                if (Materials.TryGetValue(itemId, out MaterialItem material))
                {
                    if (material.ItemData.stackLimit >= material.Count + count)
                    {
                        material.Count += count;

                        // Update Database
                        var updateQueryMat = new UpdateQueryBuilder<InventoryManager>();
                        updateQueryMat.SetFilter(w => w.OwnerId == Owner.GameUid);
                        updateQueryMat.AddValueToSet(w =>
                            (w.SubInventories[ItemType.ITEM_WEAPON] as FurnitureTab).Materials[itemId].Count, material.Count);
                        var queryStringsMat = updateQueryMat.Build();
                        await DatabaseManager.UpdateInventoryAsync(queryStringsMat);

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
                    var updateQueryMat = new UpdateQueryBuilder<InventoryManager>();
                    updateQueryMat.SetFilter(w => w.OwnerId == Owner.GameUid);
                    updateQueryMat.AddValueToSet(w =>
                        (w.SubInventories[ItemType.ITEM_WEAPON] as FurnitureTab).Materials[itemId], newMaterial);
                    var queryStringsMat = updateQueryMat.Build();
                    await DatabaseManager.UpdateInventoryAsync(queryStringsMat);

                    //TODO update codex
                    return newMaterial;
                }
            }

            //TODO Furniture
            return null;
        }


        internal override async Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            if (Materials.TryGetValue((item as MaterialItem).ItemId, out MaterialItem material))
            {
                if (material.Count - count >= 1)
                {
                    material.Count -= count;

                    // Update Database
                    var updateQueryMat = new UpdateQueryBuilder<InventoryManager>();
                    updateQueryMat.SetFilter(w => w.OwnerId == Owner.GameUid);
                    updateQueryMat.AddValueToSet(w =>
                        (w.SubInventories[ItemType.ITEM_WEAPON] as FurnitureTab).Materials[material.ItemId].Count, material.Count);
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
                        (w.SubInventories[ItemType.ITEM_WEAPON] as FurnitureTab).Materials[material.ItemId], material);
                    var queryStringsMat = updateQueryMat.Build();
                    await DatabaseManager.UpdateInventoryAsync(queryStringsMat);

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
