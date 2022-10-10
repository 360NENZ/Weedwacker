using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("MonsterDescribeExcelConfigData.json")]
    internal class MonsterDescribeData
    {
        [JsonProperty] public readonly int id;
        [JsonProperty] public readonly long nameTextMapHash;
        [JsonProperty] public readonly int titleId;
        [JsonProperty] public readonly int specialNameLabId;
        [JsonProperty] public readonly string icon;
    }
}
