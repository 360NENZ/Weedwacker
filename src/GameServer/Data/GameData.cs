using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Weedwacker.GameServer.Data.BinOut.AbilityGroup;
using Weedwacker.GameServer.Data.Excel;

namespace Weedwacker.GameServer.Data
{
    internal static class GameData
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
        public readonly static SortedList<int, AvatarCodexData> AvatarCodexDataMap = new(); // sortId
        public readonly static SortedList<int, ProudSkillData> ProudSkillDataMap = new(); // proudSkillId
        public readonly static SortedList<string, PlayerElementAbilityData> PlayerElementAbilityMap = new(); //skillDepotAbilityGroup
        static readonly JsonSerializer Serializer = new();
        static async Task LoadData<Obj, Key>(string path, Func<Obj, Key> keySelector, SortedList<Key, Obj> map) where Key : notnull
        {
            var ra = typeof(Obj).GetResourceData();
            if (ra == null || !ra.GetResourceFile(path, out var fi)) return;
            map.Clear();
            var objs = await LoadObjects<Obj[]>(fi);
            if (objs == null) return;
            foreach (var obj in objs)
                map.Add(keySelector(obj), obj);
        }
        static async Task<T?> LoadObjects<T>(FileInfo fi)
        {
            using var sr = new StringReader(await File.ReadAllTextAsync(fi.FullName));
            using var jr = new JsonTextReader(sr);
            return Serializer.Deserialize<T>(jr);
        }
        static bool GetResourceFile(this ResourceAttribute ra, string path, out FileInfo fi)
        {
            var file = Path.Combine(path, ra.Names);
            fi = new(file);
            return fi.Exists;
        }
        static ResourceAttribute? GetResourceData(this Type res) => Attribute.GetCustomAttribute(res, typeof(ResourceAttribute)) as ResourceAttribute;
        public static async Task LoadAllResourcesAsync(string resourcesPath = "./resources/ExcelBinOutput")
        {
            var tasks = new List<Task>
            {
                LoadData(resourcesPath, o => o.id, AvatarDataMap),
                LoadData(resourcesPath, o => o.Level, AvatarLevelDataMap),
                LoadData(resourcesPath, o => o.id, AvatarSkillDepotDataMap),
                LoadData(resourcesPath, o => o.id, AvatarSkillDataMap),
                LoadData(resourcesPath, o => o.level, AvatarCurveDataMap),
                LoadData(resourcesPath, o => o.fetterLevel, AvatarFetterLevelDataMap),
                LoadData(resourcesPath, o => ????, AvatarPromoteDataMap), // TODO
                LoadData(resourcesPath, o => o.talentId, AvatarTalentDataMap),
                LoadData(resourcesPath, o => o.flycloakId, AvatarFlycloakDataMap),
                LoadData(resourcesPath, o => o.costumeId, AvatarCostumeDataMap),
                LoadData(resourcesPath, o => o.sortId, AvatarCodexDataMap),
                LoadData(resourcesPath, o => o.proudSkillId, ProudSkillDataMap),
                LoadData(resourcesPath, o => ????, PlayerElementAbilityMap), // TODO
            };
            await Task.WhenAll(tasks);
        }
    }
}
