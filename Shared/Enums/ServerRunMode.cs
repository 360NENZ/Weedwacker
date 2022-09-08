using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.Shared.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServerRunMode : byte
    {
        HYBRID = 0x0,
        DISPATCH = 0x1,
        GAME = 0x2
    }
}