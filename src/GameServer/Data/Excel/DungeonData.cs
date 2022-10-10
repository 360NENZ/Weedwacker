using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("DungeonExcelConfigData.json")]
    internal class DungeonData
    {
        [JsonProperty] public readonly int id;
        [JsonProperty] public readonly long nameTextMapHash;
        [JsonProperty] public readonly long displayNameTextMapHash;
        [JsonProperty] public readonly long descTextMapHash;
        [JsonProperty] public readonly DungeonType type;
        [JsonProperty] public readonly int sceneId;
        [JsonProperty] public readonly DungeonInvolveType involveType;
        [JsonProperty] public readonly int showLevel;
        [JsonProperty] public readonly int limitLevel;
        [JsonProperty] public readonly int levelRevise;
        [JsonProperty] public readonly int passCond; // should be an enum?
        [JsonProperty] public readonly int reviveMaxCount;
        [JsonProperty] public readonly int dayEnterCount;
        //[JsonProperty] public readonly ???[] enterCostItems; // unused?
        [JsonProperty] public readonly int passRewardPreviewId;
        [JsonProperty] public readonly int settleCountdownTime;
        [JsonProperty] public readonly int failSettleCountdownTime;
        [JsonProperty] public readonly int quitSettleCountdownTime;
        [JsonProperty] public readonly SettleShowType[] settleShows;
        [JsonProperty] public readonly int statueCostId;
        [JsonProperty] public readonly int statueCostCount;
        [JsonProperty] public readonly int statueDrop;
        [JsonProperty] public readonly bool forbiddenRestart;
        [JsonProperty] public readonly string settleUIType;
        [JsonProperty] public readonly ElementType[] recommendElementTypes;
        [JsonProperty] public readonly Dictionary<string, int> levelConfigMap;
        [JsonProperty] public readonly int[] previewMonsterList;
        [JsonProperty] public readonly long gearDescTextMapHash;
        [JsonProperty] public readonly int cityId;
        [JsonProperty] public readonly string entryPicPath;
        [JsonProperty] public readonly DungeonStateType stateType;
        [JsonProperty] public readonly string factorPic;
        [JsonProperty] public readonly string factorIcon;
    }
}
