using Weedwacker.GameServer.Data;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class ShopManager
    {
        private Player.Player Owner;
        public SortedList<int, Shop> Shops = new(); // shopType
        public ShopManager(Player.Player owner)
        {
            Owner = owner;
        }

        public bool HasShop(int shopType, out Shop? shop)
        {
            if (Shops.ContainsKey(shopType))
            {
                shop = Shops[shopType];
                return true;
            }
            else
            {
                var shops = GameData.ShopDataMap.Where(w => (int)w.Value.shopType == shopType);
                if (shops.Any())
                {
                    Shop newShop = new Shop(Owner, shopType);
                    Shops.Add(shopType, newShop);
                    shop = newShop;
                    return true;
                }
                else
                {
                    shop = null;
                    return false;
                }
            }
        }
        public async Task OnLoadAsync(Player.Player owner)
        {
            Owner = owner;
            Shops.Values.AsParallel().ForAll(w => w.Goods.ForEach(p => p.OnLoadAsync()));
        }
    }
}
