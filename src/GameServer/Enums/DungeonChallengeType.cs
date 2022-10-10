using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DungeonChallengeType
    {
        CHALLENGE_NONE = 0,
        CHALLENGE_KILL_COUNT = 1,
        CHALLENGE_KILL_COUNT_IN_TIME = 2,
        CHALLENGE_SURVIVE = 3,
        CHALLENGE_TIME_FLY = 4,
        CHALLENGE_KILL_COUNT_FAST = 5,
        CHALLENGE_KILL_COUNT_FROZEN_LESS = 6,
        CHALLENGE_KILL_MONSTER_IN_TIME = 7,
        CHALLENGE_TRIGGER_IN_TIME = 8,
        CHALLENGE_GUARD_HP = 9,
        CHALLENGE_KILL_COUNT_GUARD_HP = 10,
        CHALLENGE_TRIGGER_IN_TIME_FLY = 11
    }
}
