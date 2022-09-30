using MongoDB.Bson;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class RelicTab : InventoryTab
    {
        public new readonly int InventoryLimit = 1500;
        public new Dictionary<ObjectId, ReliquaryItem> Items;

        internal override async Task<GameItem> AddItemAsync(int relicId, int count = 1)
        {
            if (Items.Count == InventoryLimit)
            {
                return null;
            }
            //TODO Generate random stats, and add item(s)

            //TODO update codex
            return null;
        }

        public async Task OnLoadAsync(Player.Player owner)
        {
            var tasks = new List<Task>();
            foreach (ReliquaryItem relic in Items.Values)
            {
                tasks.Add(relic.OnLoadAsync(owner.GetNextGameGuid()));
            }
            await Task.WhenAll(tasks);
        }

        public async Task<bool> EquipRelic(long guid)
        {
            //TODO
            return false;
        }
        public async Task<bool> UnequipRelic(long guid)
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
