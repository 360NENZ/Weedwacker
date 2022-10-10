using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SaveType
    {
        GATHER_SAVE_TYPE_LOW,
        GATHER_SAVE_TYPE_MID,
        GATHER_SAVE_TYPE_HIGH,
        GATHER_SAVE_TYPE_OWN
    }
}
