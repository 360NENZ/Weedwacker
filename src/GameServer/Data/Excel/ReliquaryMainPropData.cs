using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ReliquaryMainPropExcelConfigData.json")]
    internal class ReliquaryMainPropData
    {
        [JsonProperty] public readonly int id;
        [JsonProperty] public readonly int propDepotId;
        [JsonProperty] public readonly FightProperty propType;
        [JsonProperty] public readonly int weight;
    }
}
