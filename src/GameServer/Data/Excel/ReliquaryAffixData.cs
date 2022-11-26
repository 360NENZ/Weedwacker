using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ReliquaryAffixExcelConfigData.json")]
    internal class ReliquaryAffixData
    {
        [JsonProperty] public readonly int id;
        [JsonProperty] public readonly int depotId;
        [JsonProperty] public readonly int groupId;
        [JsonProperty] public readonly FightProperty propType;
        [JsonProperty] public readonly float propValue;
        [JsonProperty] public readonly int weight;
        [JsonProperty] public readonly int upgradeWeight;
    }
}
