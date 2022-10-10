using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DungeonType
    {
        DUNGEON_NONE = 0,
        DUNGEON_PLOT = 1,
        DUNGEON_FIGHT = 2,
        DUNGEON_DAILY_FIGHT = 3,
        DUNGEON_WEEKLY_FIGHT = 4,
        DUNGEON_DISCARDED = 5,
        DUNGEON_TOWER = 6,
        DUNGEON_BOSS = 7
    }
}
