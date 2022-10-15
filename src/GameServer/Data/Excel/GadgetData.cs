using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("GadgetExcelConfigData.json")]
    internal class GadgetData
    {
        [JsonProperty] public readonly GadgetType type;
        [JsonProperty] public readonly string jsonName;
        [JsonProperty] public readonly bool hasMove;
        [JsonProperty] public readonly bool hasAudio;
        [JsonProperty] public readonly string[] tags;
        [JsonProperty] public readonly string itemJsonName;
        [JsonProperty] public readonly string inteeIconName;
        [JsonProperty] public readonly long interactNameTextMapHash;
        [JsonProperty] public readonly int id;
        [JsonProperty] public readonly long nameTextMapHash;
        [JsonProperty] public readonly long prefabPathHashSuffix;
        [JsonProperty] public readonly int prefabPathHashPre;
        [JsonProperty] public readonly int campId;
        [JsonProperty] public readonly string lODPatternName;
    }
}
