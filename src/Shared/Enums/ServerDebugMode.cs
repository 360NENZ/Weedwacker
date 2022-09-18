using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.Shared.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServerDebugMode : byte
    {
        ALL = 0x0,
        MISSING = 0x1,
        WHITELIST = 0x2,
        BLACKLIST = 0x3,
        NONE = 0x4
    }
}