using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DungeonChallengeRecordType
    {
        CHALLENGE_RECORD_TYPE_NONE = 0,
        CHALLENGE_RECORD_TYPE_IN_TIME = 1
    }
}
