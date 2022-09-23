using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;
using static Weedwacker.GameServer.Data.ResourceAttribute;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarExcelConfigData.json", LoadPriority.LOW)]
    internal class AvatarData
    {
        [JsonProperty]
        public readonly string? iconName;
        [JsonProperty]
        public readonly string? sideIconName;
        [JsonProperty]
        public readonly string? bodyType;
        [JsonProperty]
        public readonly string? qualityType;
        [JsonProperty]
        public readonly double chargeEfficiency;
        [JsonProperty]
        public readonly int initialWeapon;
        [JsonProperty]
        public readonly WeaponType weaponType;
        [JsonProperty]
        public readonly string? imageName;
        [JsonProperty]
        public readonly int avatarPromoteId;
        [JsonProperty]
        public readonly string? cutsceneShow;
        [JsonProperty]
        public readonly int skillDepotId;
        [JsonProperty]
        public readonly double staminaRecoverSpeed;
        [JsonProperty]
        public readonly int[] candSkillDepotIds;
        [JsonProperty]
        public readonly int manekinMotionConfig;
        [JsonProperty]
        public readonly string? avatarIdentityType;
        [JsonProperty]
        public readonly List<int>? avatarPromoteRewardLevelList;
        [JsonProperty]
        public readonly List<int>? avatarPromoteRewardIdList;
        [JsonProperty]
        public readonly int featureTagGroupID;
        [JsonProperty]
        public readonly long nameTextMapHash;
        [JsonProperty]
        public readonly float hpBase;
        [JsonProperty]
        public readonly float attackBase;
        [JsonProperty]
        public readonly float defenseBase;
        [JsonProperty]
        public readonly float critical;
        [JsonProperty]
        public readonly float criticalHurt;
        [JsonProperty]
        public readonly List<PropGrowCurve>? propGrowCurves;
        [JsonProperty]
        public readonly int id;
        [JsonProperty]
        public readonly string? LODPatternName;
    }
}
