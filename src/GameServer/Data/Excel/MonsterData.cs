using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("MonsterExcelConfigData.json")]
    internal class MonsterData
    {
        [JsonProperty] public readonly string monsterName;
        [JsonProperty] public readonly MonsterType type;
        [JsonProperty] public readonly SecurityLevel securityLevel;
        [JsonProperty] public readonly long scriptDataPathHashSuffix;
        [JsonProperty] public readonly int scriptDataPathHashPre;
        [JsonProperty] public readonly string serverScript;
        [JsonProperty] public readonly long combatConfigHashSuffix;
        [JsonProperty] public readonly int combatConfigHashPre;
        [JsonProperty] public readonly int[] affix;
        [JsonProperty] public readonly string ai;
        [JsonProperty] public readonly bool isAIHashCheck;
        [JsonProperty] public readonly int[] equips;
        [JsonProperty] public readonly HpDrop[] hpDrops;
        [JsonProperty] public readonly int killDropId;
        [JsonProperty] public readonly VisionLevel visionLevel;
        [JsonProperty] public readonly string excludeWeathers;
        [JsonProperty] public readonly int featureTagGroupId;
        [JsonProperty] public readonly int mpPropId;
        [JsonProperty] public readonly string skin;
        [JsonProperty] public readonly int describeId;
        [JsonProperty] public readonly int combatBGMLevel;
        [JsonProperty] public readonly int entityBudgetLevel;
        [JsonProperty] public readonly float hpBase;
        [JsonProperty] public readonly float attackBase;
        [JsonProperty] public readonly float defenseBase;
        [JsonProperty] public readonly float fireSubHurt;
        [JsonProperty] public readonly float grassSubHurt;
        [JsonProperty] public readonly float waterSubHurt;
        [JsonProperty] public readonly float elecSubHurt;
        [JsonProperty] public readonly float windSubHurt;
        [JsonProperty] public readonly float iceSubHurt;
        [JsonProperty] public readonly float rockSubHurt;
        [JsonProperty] public readonly PropGrowCurve[] propGrowCurves;
        [JsonProperty] public readonly float physicalSubHurt;
        [JsonProperty] public readonly long prefabPathRagdollHashSuffix;
        [JsonProperty] public readonly int prefabPathRagdollHashPre;
        [JsonProperty] public readonly int id;
        [JsonProperty] public readonly long nameTextMapHash;
        [JsonProperty] public readonly long prefabPathHashSuffix;
        [JsonProperty] public readonly int prefabPathHashPre;
        [JsonProperty] public readonly long prefabPathRemoteHashSuffix;
        [JsonProperty] public readonly int prefabPathRemoteHashPre;
        [JsonProperty] public readonly long controllerPathHashSuffix;
        [JsonProperty] public readonly int controllerPathHashPre;
        [JsonProperty] public readonly long controllerPathRemoteHashSuffix;
        [JsonProperty] public readonly int controllerPathRemoteHashPre;
        [JsonProperty] public readonly int campId;
        [JsonProperty] public readonly string lODPatternName;

        public class HpDrop
        {
            [JsonProperty] public readonly int dropId;
            [JsonProperty] public readonly int hpPercent;
        }
    }

}
