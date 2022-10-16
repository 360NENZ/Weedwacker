using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DungeonEntryType
    {
        None,
        Daily,
        Sumo,
        ActivityPotion,
        Tower,
        ChannellerSlabLoop,
        ChannellerSlabOneOff,
        ActivityHachi,
        ActivitySummerTimeV2Story,
        Roguelike,
        ActivitySummerTimeV2Battle,
        Effigy,
        FleurFair,
        Arena,
        BlitzRush,
        ActivityMiniEldritch,
        CustomLevel,
        CrystalLink,
        ActivityInstableSpray,
        ActivityMuqadasPotion,
    }
}
