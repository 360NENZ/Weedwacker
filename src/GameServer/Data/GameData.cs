using Weedwacker.GameServer.Data.Excel;

namespace Weedwacker.GameServer.Data
{
    internal class GameData
    {
        public readonly static SortedList<int, AvatarData> AvatarDataMap = new(); // AvatarId
        public readonly static SortedList<int, AvatarLevelData> AvatarLevelDataMap = new(); // Level
        public readonly static SortedList<int, AvatarSkillDepotData> AvatarSkillDepotDataMap = new(); // SkillDepotId
        public readonly static SortedList<int, AvatarSkillData> AvatarSkillDataMap = new(); // SkillId
        public readonly static SortedList<int, AvatarCurveData> AvatarCurveDataMap = new(); // level
        public readonly static SortedList<int, AvatarFetterLevelData> AvatarFetterLevelDataMap = new(); // level
        public readonly static SortedList<int, SortedList<int,AvatarPromoteData>> AvatarPromoteDataMap = new(); // <PromoteId,<level,Data>>
        public readonly static SortedList<int, AvatarTalentData> AvatarTalentDataMap = new(); // talentId
        public readonly static SortedList<int, AvatarFlycloakData> AvatarFlycloakDataMap = new(); // flycloakId
        public readonly static SortedList<int, AvatarCostumeData> AvatarCostumeDataMap = new(); // costumeId
        public readonly static SortedList<int, AvatarCodexData> AvatarCodexDataMap = new();  // sortId
        public readonly static SortedList<int, ProudSkillData> ProudSkillDataMap = new(); // proudSkillId
    }
}
