using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DungeonCondType
    {
        DUNGEON_COND_NONE = 0,
        DUNGEON_COND_KILL_MONSTER = 3,
        DUNGEON_COND_KILL_GROUP_MONSTER = 5,
        DUNGEON_COND_KILL_TYPE_MONSTER = 7,
        DUNGEON_COND_FINISH_QUEST = 9,
        DUNGEON_COND_KILL_MONSTER_COUNT = 11,
        DUNGEON_COND_IN_TIME = 13,
        DUNGEON_COND_FINISH_CHALLENGE = 14
    }
}
