using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ShopGoodsExcelConfigData.json")]
    internal class ShopGoodsData
    {
        [JsonProperty] public readonly int goodsId;
        [JsonProperty] public readonly long subTagNameTextMapHash;
        [JsonProperty] public readonly int shopType;
        [JsonProperty] public readonly int itemId;
        [JsonProperty] public readonly int itemCount;
        [JsonProperty] public readonly int costScoin;
        [JsonProperty] public readonly int costHcoin;
        [JsonProperty] public readonly int costMcoin;
        [JsonProperty] public readonly ItemParamData[] costItems;
        [JsonProperty] public readonly int minPlayerLevel;
        [JsonProperty] public readonly int maxPlayerLevel;
        [JsonProperty] public readonly int buyLimit;
        [JsonProperty] public readonly int subTabId;
        [JsonProperty] public readonly ShopRefreshType refreshType;
        [JsonProperty] public readonly int refreshParam;
        [JsonProperty] public readonly string? beginTime;
        [JsonProperty] public readonly string? endTime;
        [JsonProperty] public readonly PreConditionType precondition;
        [JsonProperty] public readonly int preconditionParam;
        [JsonProperty] public readonly string[]? preconditionParamList;
        [JsonProperty] public readonly bool preconditionHidden;
        [JsonProperty] public readonly int minShowLevel;
        [JsonProperty] public readonly int sortLevel;
        [JsonProperty] public readonly int secondarySheetId;
        //[JsonProperty] public readonly ??? platformTypeList;
    }
}
