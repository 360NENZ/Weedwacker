using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum EquipType
    {
        EQUIP_NONE = 0,
        EQUIP_BRACER = 1,
        EQUIP_NECKLACE = 2,
        EQUIP_SHOES = 3,
        EQUIP_RING = 4,
        EQUIP_DRESS = 5,
        EQUIP_WEAPON = 6
    }
}
