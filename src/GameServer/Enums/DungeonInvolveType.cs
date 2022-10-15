using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DungeonInvolveType
    {
        INVOLVE_NONE = 0,
        INVOLVE_ONLY_SINGLE = 1,
        INVOLVE_SINGLE_MULTIPLE = 2,
        INVOLVE_DYNAMIC_MULTIPLE = 3,
        INVOLVE_ONLY_MULTIPLE = 4
    }
}
