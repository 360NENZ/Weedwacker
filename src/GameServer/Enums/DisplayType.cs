using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum DisplayType
    {
        BARTENDER_ITEM,
        EXHIBITION_DISPLAY_TYPE_INT,
        EXHIBITION_DISPLAY_TYPE_TIME_MINSEC,
        Literally,
        TextMap
    }
}
