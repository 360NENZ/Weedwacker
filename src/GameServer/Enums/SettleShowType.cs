using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SettleShowType
    {
        SETTLE_SHOW_NONE,
        SETTLE_SHOW_TIME_COST,
        SETTLE_SHOW_OPEN_CHEST_COUNT,
        SETTLE_SHOW_KILL_MONSTER_COUNT,
        SETTLE_SHOW_BLACKSCREEN
    }
}
