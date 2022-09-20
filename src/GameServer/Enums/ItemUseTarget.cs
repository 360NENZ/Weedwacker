using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum ItemUseTarget
    {
        ITEM_USE_TARGET_NONE = 0,
        ITEM_USE_TARGET_CUR_AVATAR = 1,
        ITEM_USE_TARGET_CUR_TEAM  = 2,
        ITEM_USE_TARGET_SPECIFY_AVATAR  = 3,
        ITEM_USE_TARGET_SPECIFY_ALIVE_AVATAR  = 4,
        ITEM_USE_TARGET_SPECIFY_DEAD_AVATAR  = 5
    }
}
