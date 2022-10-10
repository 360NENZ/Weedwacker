using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("GatherExcelConfigData.json")]
    internal class GatherData
    {
        [JsonProperty] public readonly int id;
        [JsonProperty] public readonly int areaId;
        [JsonProperty] public readonly int pointType;
        [JsonProperty] public readonly int gadgetId;
        [JsonProperty] public readonly int itemId;
        //[JsonProperty] public readonly ???[] extraItemIdVec;
        [JsonProperty] public readonly string pointLocation;
        [JsonProperty] public readonly int cd;
        [JsonProperty] public readonly int priority;
        [JsonProperty] public readonly int refreshId;
        [JsonProperty] public readonly BlockLimit[] blockLimits;
        [JsonProperty] public readonly bool initDisableInteract;
        [JsonProperty] public readonly bool isForbidGuest;
        [JsonProperty] public readonly SaveType saveType;

        public class BlockLimit
        {
            [JsonProperty] public readonly int blockId;
            [JsonProperty] public readonly int count;
        }
    }
}
