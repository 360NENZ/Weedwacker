using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SceneTagCondType
    {
        NONE, // Don't use
        SCENE_TAG_COND_TYPE_SPECIFIC_ACTIVITY_OPEN,
        SCENE_TAG_COND_TYPE_ACTIVITY_CONTENT_OPEN,
        SCENE_TAG_COND_TYPE_QUEST_GLOBAL_VAR_EQUAL,
        SCENE_TAG_COND_TYPE_QUEST_FINISH,
    }
}
