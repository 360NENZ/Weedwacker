using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MonsterType
    {
        MONSTER_ORDINARY,
        MONSTER_BOSS
    }
}
