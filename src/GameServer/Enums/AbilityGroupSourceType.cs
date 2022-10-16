using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AbilityGroupSourceType
    {
        ABILITY_GROUP_SOURCE_AVATAR_SKILL_DEPOT,
        ABILITY_GROUP_SOURCE_QUEST,
        ABILITY_GROUP_SOURCE_GALLERY,
        ABILITY_GROUP_SOURCE_CHALLENGE,
        ABILITY_GROUP_SOURCE_HUNTING,
        ABILITY_GROUP_SOURCE_WIDGET,
        ABILITY_GROUP_SOURCE_FISHING,
        ABILITY_GROUP_SOURCE_ACTIVITY
    }
}
