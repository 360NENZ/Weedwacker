using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CycleDungeonType
    {
        CYCLE_DUNGEON_NONE = 0,
        CYCLE_DUNGEON_DVALIN = 1,
        CYCLE_DUNGEON_AVATAR_EXP = 2,
        CYCLE_DUNGEON_AVATAR_SKILL = 3,
        CYCLE_DUNGEON_WEAPON_PROMOTE = 4,
        CYCLE_DUNGEON_RELIQUARY = 5,
        CYCLE_DUNGEON_SCOIN = 6,
        CYCLE_DUNGEON_WEEKLY = 7
    }
}
