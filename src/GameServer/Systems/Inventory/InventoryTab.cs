using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Systems.Player;

namespace Weedwacker.GameServer.Systems.Inventory
{
    [BsonKnownTypes(typeof(BattlePassTab), typeof(FoodTab),
    typeof(FurnitureTab), typeof(GadgetTab), typeof(MaterialsTab), typeof(PreciousTab),
    typeof(PromoteTab), typeof(QuestTab), typeof(RelicTab), typeof(WeaponTab))]
    internal abstract class InventoryTab : SubInventory
    {
        [BsonIgnore] public const int InventoryLimit = 9999;
        public Dictionary<int, GameItem> Items;

        protected InventoryTab(Player.Player owner, InventoryManager inventory) : base(owner, inventory) { }
    }
}
