using Newtonsoft.Json;
using Weedwacker.GameServer.Systems;
using static Weedwacker.GameServer.Data.ResourceAttribute;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarSkillExcelConfigData.json", LoadPriority.HIGHEST)]
    internal class AvatarSkillData : GameResource
    {
        [JsonProperty]
        public readonly int id;
        [JsonProperty]
        public readonly double cdTime;
        [JsonProperty]
        public readonly int costElemVal;
        [JsonProperty]
        public readonly int maxChargeNum;
        [JsonProperty]
        public readonly int triggerID;
        [JsonProperty]
        public readonly bool isAttackCameraLock;
        [JsonProperty]
        public readonly string? dragType;
        [JsonProperty]
        public readonly bool showIconArrow;
        [JsonProperty]
        public readonly int proudSkillGroupId;
        [JsonProperty]
        public readonly Element? costElemType;
        [JsonProperty]
        public readonly long nameTextMapHash;
        [JsonProperty]
        public readonly long descTextMapHash;
        [JsonProperty]
        public readonly string? abilityName;
        [JsonProperty]
        public readonly string? skillIcon;
        [JsonProperty]
        public readonly bool isRanged;
        [JsonProperty]
        public readonly string? lockShape;
        [JsonProperty]
        public readonly string? globalValueKey;
        [JsonProperty]
        public readonly string? buffIcon;
        [JsonProperty]
        public readonly double[] lockWeightParams;
    }
}
