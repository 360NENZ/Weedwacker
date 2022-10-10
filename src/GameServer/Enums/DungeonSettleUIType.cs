using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DungeonSettleUIType
    {
        SETTLE_UI_AlWAYS_SHOW = 0,
        SETTLE_UI_ON_SUCCESS = 1,
        SETTLE_UI_ON_FAIL = 2,
        SETTLE_UI_NEVER_SHOW = 3
    }
}
