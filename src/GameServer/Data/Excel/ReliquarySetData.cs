using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ReliquarySetExcelConfigData.json")]
    internal class ReliquarySetData
    {
        [JsonProperty] public readonly int setId;
        [JsonProperty] public readonly string setIcon;
        [JsonProperty] public readonly int[] setNeedNum;

        [JsonProperty] public readonly int EquipAffixId;
        [JsonProperty] public readonly int[] containsList;
        [JsonProperty] public readonly int DisableFilter;
        // Missing 2 properties
        [JsonProperty] public readonly long[] textList;
    }
}
