using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AbilityGroupTargetType
    {
        NONE,
        ABILITY_GROUP_TARGET_AVATAR,
        ABILITY_GROUP_TARGET_TEAM
    }
}
