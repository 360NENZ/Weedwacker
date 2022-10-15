using MongoDB.Bson.Serialization.Attributes;

namespace Weedwacker.GameServer.Systems.Inventory
{
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(typeof(MaterialSubInv), typeof(InventoryTab), typeof(BattlePassTab), typeof(FoodTab),
        typeof(FurnitureTab), typeof(GadgetTab), typeof(MaterialsTab), typeof(PreciousTab),
        typeof(PromoteTab), typeof(QuestTab), typeof(RelicTab), typeof(WeaponTab))]
    internal abstract class SubInventory
    {
        [BsonIgnore] protected Player.Player? Owner;
        [BsonIgnore] protected InventoryManager? Inventory;

        // MONGODB ONLY
        public SubInventory() { }
        public SubInventory(Player.Player owner, InventoryManager inventory)
        {
            Owner = owner;
            Inventory = inventory;
        }

        // return null if no update item
        internal abstract Task<GameItem?> AddItemAsync(int itemId, int count = 1);

        // Delete if count reaches 0
        internal abstract Task<bool> RemoveItemAsync(GameItem item, int count = 1);

        // Called by DatabaseManager
        public abstract Task OnLoadAsync(Player.Player owner, InventoryManager inventory);
    }
}
