using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GadgetType
    {
        Gear,
        Bullet,
        Field,
        AirflowField,
        SpeedupField,
        MonsterEquip,
        Platform
    }
}
