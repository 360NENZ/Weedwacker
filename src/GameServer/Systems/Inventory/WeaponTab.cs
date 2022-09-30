using MongoDB.Bson;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class WeaponTab : InventoryTab
    {
        public new readonly int InventoryLimit = 2000;
        public new Dictionary<ObjectId, WeaponItem> Items;
        internal override async Task<GameItem> AddItemAsync(int relicId, int count = 1)
        {
            if (Items.Count == InventoryLimit)
            {
                return null;
            }
            //TODO add item(s)

            //TODO update codex
            return null;
        }
        public async Task OnLoadAsync(Player.Player owner)
        {
            var tasks = new List<Task>();
            foreach(WeaponItem weapon in Items.Values)
            {
                tasks.Add(weapon.OnLoadAsync(owner.GetNextGameGuid()));
            }
            await Task.WhenAll(tasks);
        }
        public async Task<bool> EquipWeapon(long guid)
        {
            //TODO
            return false;
        }
        public async Task<bool> UnequipWeapon(long guid)
        {
            //TODO
            return false;
        }

        internal override Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            throw new NotImplementedException();
        }
    }
}
