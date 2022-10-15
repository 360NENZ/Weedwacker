using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShopRefreshType
    {
        SHOP_REFRESH_DAILY,
        SHOP_REFRESH_WEEKLY,
        SHOP_REFRESH_MONTHLY
    }
}
