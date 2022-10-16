using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarkIconType
    {
        MarkMusicGameV3NPC,
        MarkArenaChallengeV3,
        MarkAlcorTransmit,
        MarkQunyugeTransmit,
        MarkIrodoriMasterNPC,
    }
}
