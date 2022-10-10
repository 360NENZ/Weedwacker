using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DungeonStateType
    {
        DUNGEON_STATE_TEST,
        DUNGEON_STATE_RELEASE
    }
}
