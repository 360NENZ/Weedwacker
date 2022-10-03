using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ReliquaryLevelExcelConfigData.json")]
    internal class ReliquaryLevelData
    {
        [JsonProperty] public readonly int rank;
        [JsonProperty] public readonly int level;
        [JsonProperty] public readonly int exp;
        [JsonProperty] public readonly List<RelicLevelProperty> addProps;

        public class RelicLevelProperty
        {
            [JsonProperty] public readonly FightProperty propType;
            [JsonProperty] public readonly float value;
        }
    }
}
