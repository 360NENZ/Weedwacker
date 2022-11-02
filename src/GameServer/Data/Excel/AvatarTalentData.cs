using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using static Weedwacker.GameServer.Data.ResourceAttribute;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarTalentExcelConfigData.json")]
    public class AvatarTalentData
    {
        [JsonProperty] public readonly int talentId;
        [JsonProperty] public readonly int prevTalent;
        [JsonProperty] public readonly long nameTextMapHash;
        [JsonProperty] public readonly string icon;
        [JsonProperty] public readonly int mainCostItemId;
        [JsonProperty] public readonly int mainCostItemCount;
        [JsonProperty] public readonly string openConfig;
        [JsonProperty] public readonly FightPropData[] addProps;
        [JsonProperty] public readonly double[] paramList;
    }
}
