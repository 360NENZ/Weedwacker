using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point
{
    internal class DungeonEntry : BasePoint
    {
        [JsonProperty] public readonly int[] cutsceneList;
        [JsonProperty] public readonly int[] dungeonIds;
        //[JsonProperty] public readonly ??? dungeonQuestConditionList; unused?
        [JsonProperty] public readonly Dictionary<string, float>? size;
        [JsonProperty] public readonly string titleTextId;
        [JsonProperty] public readonly string? mapVisibility;
        [JsonProperty] public readonly bool forbidSimpleUnlock;
        [JsonProperty] public readonly bool groupLimit;
        [JsonProperty] public readonly DungeonEntryType dungeonEntryType;
        [JsonProperty] public readonly int[] dungeonRosterList;
    }
}
