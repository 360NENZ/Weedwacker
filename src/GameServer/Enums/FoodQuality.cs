using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum FoodQuality
    {
        FOOD_QUALITY_STRANGE,
        FOOD_QUALITY_ORDINARY,
        FOOD_QUALITY_DELICIOUS
    }
}
