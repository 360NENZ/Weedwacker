using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DungeonChallengeCondType
    {
        CHALLENGE_COND_NONE = 0,
        CHALLENGE_COND_IN_TIME = 1,
        CHALLENGE_COND_ALL_TIME = 2,
        CHALLENGE_COND_KILL_COUNT = 3,
        CHALLENGE_COND_SURVIVE = 4,
        CHALLENGE_COND_TIME_INC = 5,
        CHALLENGE_COND_KILL_FAST = 6,
        CHALLENGE_COND_DOWN_LESS = 7,
        CHALLENGE_COND_BEATEN_LESS = 8,
        CHALLENGE_COND_UNNATURAL_COUNT = 9,
        CHALLENGE_COND_FROZEN_LESS = 10,
        CHALLENGE_COND_KILL_MONSTER = 11,
        CHALLENGE_COND_TRIGGER = 12,
        CHALLENGE_COND_GUARD_HP = 13,
        CHALLENGE_COND_TIME_DEC = 14
    }
}
