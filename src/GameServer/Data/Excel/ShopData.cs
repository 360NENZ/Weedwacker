using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ShopExcelConfigData.json")]
    internal class ShopData
    {
        [JsonProperty] public readonly int shopId;
        [JsonProperty] public readonly ShopType shopType;
        [JsonProperty] public readonly ShopRefreshType refreshType;
        [JsonProperty] public readonly int refreshParam;
        [JsonProperty] public readonly OpenStateType openStateType;
        [JsonProperty] public readonly int cityId;
        [JsonProperty] public readonly int cityDiscountLevel;
        [JsonProperty] public readonly int scoinDiscountRate;
        [JsonProperty] public readonly int vipFuncId;

    }
}
