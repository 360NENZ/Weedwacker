using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SceneType
    {
        SCENE_NONE,
        SCENE_WORLD,
        SCENE_DUNGEON,
        SCENE_ROOM,
        SCENE_HOME_WORLD,
        SCENE_HOME_ROOM,
        SCENE_ACTIVITY
    }
}
