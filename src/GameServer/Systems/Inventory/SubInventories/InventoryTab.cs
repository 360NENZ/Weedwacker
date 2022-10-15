using MongoDB.Bson.Serialization.Attributes;

namespace Weedwacker.GameServer.Systems.Inventory
{
    [BsonKnownTypes(typeof(BattlePassTab), typeof(FoodTab),
    typeof(FurnitureTab), typeof(GadgetTab), typeof(MaterialsTab), typeof(PreciousTab),
    typeof(PromoteTab), typeof(QuestTab), typeof(RelicTab), typeof(WeaponTab))]
    internal abstract class InventoryTab : SubInventory
    {
        [BsonIgnore] public const int InventoryLimit = 9999;
        [BsonDictionaryOptions(MongoDB.Bson.Serialization.Options.DictionaryRepresentation.ArrayOfDocuments)]
        public Dictionary<int, GameItem> Items = new();

        protected InventoryTab(Player.Player owner, InventoryManager inventory) : base(owner, inventory)
        {
            Items = new();
        }
    }
}
