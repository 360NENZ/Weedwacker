using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("WeatherExcelConfigData.json")]
    internal class WeatherData
    {
        [JsonProperty] public readonly int areaId;
        [JsonProperty] public readonly int weatherAreaId;
        [JsonProperty] public readonly string maxHeightStr;
        [JsonProperty] public readonly int gadgetId;
        [JsonProperty] public readonly bool isDefaultValid;
        [JsonProperty] public readonly int priority;
        [JsonProperty] public readonly string profileName;
        [JsonProperty] public readonly ClimateType defaultClimate;
        [JsonProperty] public readonly bool isUseDefault;
        [JsonProperty] public readonly int sceneId;
    }
}
