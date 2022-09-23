using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("EquipAffixExcelConfigData.json")]
    public class EquipAffixData
    {
        [JsonProperty]
        public readonly int affixId;
        [JsonProperty]
        public readonly int id;
        [JsonProperty]
        public readonly int level;
        [JsonProperty]
        public readonly long nameTextMapHash;
        [JsonProperty]
        public readonly string openConfig;
        [JsonProperty]
        public readonly FightPropData[] addProps;
        [JsonProperty]
        public readonly float[] paramList;
    }
}
