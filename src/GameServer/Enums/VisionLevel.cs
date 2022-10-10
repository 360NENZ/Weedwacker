using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VisionLevel
    {
        VISION_LEVEL_LITTLE_REMOTE,
        VISION_LEVEL_NEARBY,
        VISION_LEVEL_SUPER_NEARBY,
    }
}
