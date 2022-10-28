using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReactionType
    {
        None,
        CrystallizeElectric,
        Explode,
        Shock,
        Superconductor,
        SwirlElectric,
        SwirlFire,
        SwirlIce,
        SwirlWater,
    }
}
