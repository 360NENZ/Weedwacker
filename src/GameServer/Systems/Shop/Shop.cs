using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Database;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Shop
{
    internal class Shop
    {
        private Player.Player Customer;
        [BsonElement] public int ShopType { get; private set; }
        [BsonElement] public HashSet<ShopGoodInfo> Goods { get; private set; } = new();
        [BsonElement] public int NextRefreshTime { get; private set; } = int.MaxValue; //TODO
        public Shop(Player.Player customer, int shopType)
        {
            Customer = customer;
            ShopType = shopType;
            var allGoods = GameData.ShopGoodsDataMap.Values.Where(w => w.shopType == shopType).ToList();
            allGoods.ForEach(w => Goods.Add(new ShopGoodInfo(w)));
            NextRefreshTime = GameServer.GetShopNextRefreshTime(shopType);
        }

        public async Task OnLoadAsync(Player.Player customer)
        {
            Customer = customer;
            await CheckRefreshTime();
        }

        public async Task CheckRefreshTime()
        {
            int nextRefresh = GameServer.GetShopNextRefreshTime(ShopType);
            if (NextRefreshTime <= nextRefresh)
            {
                NextRefreshTime = nextRefresh;
                Goods.AsParallel().ForAll(w => w.ResetBoughtNum());
                //Update database
                var filter1 = Builders<ShopManager>.Filter.Where(w => w.OwnerId == Customer.GameUid);
                var update1 = Builders<ShopManager>.Update.Set(w => w.Shops[ShopType], this);
                await DatabaseManager.UpdateShopsAsync(filter1, update1);
            }
        }

        public Shared.Network.Proto.Shop ToProto()
        {
            // TODO: CityReputationLevel
            Shared.Network.Proto.Shop shopProto = new()
            {
                ShopType = (uint)ShopType,
                /*
                CityId = ,
                CityReputationLevel =
                */
            };

            List<ShopGoods> goodsList = new();
            foreach (ShopGoodInfo info in Goods)
            {

                goodsList.Add(info.ToProto(NextRefreshTime));
            }
            shopProto.GoodsList.Add(goodsList);

            return shopProto;
        }
    }
}
