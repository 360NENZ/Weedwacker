using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum WeaponType
    {
        WEAPON_NONE = 0,
        WEAPON_SWORD_ONE_HAND = 1,
        WEAPON_CROSSBOW = 2,
        WEAPON_STAFF = 3,
        WEAPON_DOUBLE_DAGGER = 4,
        WEAPON_KATANA = 5,
        WEAPON_SHURIKEN = 6,
        WEAPON_STICK = 7,
        WEAPON_SPEAR = 8,
        WEAPON_SHIELD_SMALL = 9,
        WEAPON_CATALYST = 10,
        WEAPON_CLAYMORE = 11,
        WEAPON_BOW = 12,
        WEAPON_POLE = 13
    }
}
