
using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarPromoteExcelConfigData.json")]
    public class AvatarPromoteData
    {
        [JsonProperty]
        public readonly int avatarPromoteId;
        [JsonProperty]
        public readonly int promoteLevel;
        [JsonProperty]
        public readonly string promoteAudio;
        [JsonProperty]
        public readonly int scoinCost;
        [JsonProperty]
        public readonly ItemParamData[] costItems;
        [JsonProperty]
        public readonly int unlockMaxLevel;
        [JsonProperty]
        public readonly FightPropData[] addProps;
        [JsonProperty]
        public readonly int requiredPlayerLevel;
    }
}
