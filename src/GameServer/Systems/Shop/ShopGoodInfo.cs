using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Shop
{
    internal class ShopGoodInfo
    {
        [BsonElement] public int GoodsId { get; private set; }
        [BsonIgnore] public ShopGoodsData Data { get; private set; }
        public int BoughtNum { get; private set; } = 0;

        public ShopGoodInfo(int goodsId)
        {
            GoodsId = goodsId;
            Data = GameData.ShopGoodsDataMap[goodsId];
        }

        public ShopGoodInfo(ShopGoodsData data)
        {
            GoodsId = data.goodsId;
            Data = data;
        }

        public void ResetBoughtNum()
        {
            BoughtNum = 0;
        }
        public Task OnLoadAsync()
        {
            Data = GameData.ShopGoodsDataMap[GoodsId];
            return Task.CompletedTask;
        }

        public ShopGoods ToProto(int nextRefresh)
        {
            //TODO
            ShopGoods goods = new ShopGoods()
            {
                GoodsId = (uint)GoodsId,
                GoodsItem = new ItemParam() { ItemId = (uint)Data.itemId, Count = (uint)Data.itemCount },
                Scoin = (uint)Data.costScoin,
                Hcoin = (uint)Data.costHcoin,
                Mcoin = (uint)Data.costMcoin,
                BuyLimit = (uint)Data.buyLimit,
                //TODO
                BeginTime = 0,
                EndTime = 1924992000,
                MinLevel = (uint)Data.minPlayerLevel,
                MaxLevel = (uint)Data.maxPlayerLevel,
                SecondarySheetId = (uint)Data.secondarySheetId,
                DisableType = 0, //TODO

            };

            if (Data.costItems != null)
            {
                Data.costItems.AsParallel().ForAll(w => goods.CostItemList.Add(new ItemParam() { ItemId = (uint)w.id, Count = (uint)w.count }));
            }
            if (Data.preconditionParamList != null)
            {
                foreach (string paramList in Data.preconditionParamList.Where(w => !w.Equals("")))
                {
                    int[] ids = (int[])paramList.Split(",").Select(w => int.Parse(w));
                    ids.AsParallel().ForAll(w => goods.PreGoodsIdList.Add((uint)w));
                }
            }
            else if (Data.preconditionParam != 0)
                goods.PreGoodsIdList.Add((uint)Data.preconditionParam);

            goods.BoughtNum = (uint)BoughtNum;
            goods.NextRefreshTime = (uint)nextRefresh;

            return goods;
        }
    }
}
