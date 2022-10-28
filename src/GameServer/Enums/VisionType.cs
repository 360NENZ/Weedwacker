using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VisionType
    {
        // Copied from protos
        None = 0,
        Meet = 1,
        Reborn = 2,
        Replace = 3,
        WaypointReborn = 4,
        Miss = 5,
        Die = 6,
        GatherEscape = 7,
        Refresh = 8,
        Transport = 9,
        ReplaceDie = 10,
        ReplaceNoNotify = 11,
        Born = 12,
        Pickup = 13,
        Remove = 14,
        ChangeCostume = 15,
        FishRefresh = 16,
        FishBigShock = 17,
        FishQteSucc = 18,
        Unk2700Epfkmoipadb = 19,

        // Used in binout
        VisionReborn = 2,
        VisionReplaceDie = 10,
    }
}
