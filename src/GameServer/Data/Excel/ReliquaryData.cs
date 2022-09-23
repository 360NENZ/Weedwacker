using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ReliquaryExcelConfigData.json")]
    internal class ReliquaryData : ItemData
    {
        [JsonProperty]
        public readonly EquipType equipType;
        [JsonProperty]
        public readonly string showPic;
        [JsonProperty]
        public readonly int mainPropDepotId;
        [JsonProperty]
        public readonly int appendPropDepotId;
        [JsonProperty]
        public readonly int[]? addPropLevels;
        [JsonProperty]
        public readonly int appendPropNum;
        [JsonProperty]
        public readonly int baseConvExp;
        [JsonProperty]
        public readonly int maxLevel;
        [JsonProperty]
        public readonly int weight;
        [JsonProperty]
        public readonly int setId;
        [JsonProperty]
        public readonly int gadgetId;
    }
}
