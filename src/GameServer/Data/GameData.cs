using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.AbilityGroup;
using Weedwacker.GameServer.Data.BinOut.Scene.Point;
using Weedwacker.GameServer.Data.BinOut.Talent.AvatarTalents;
using Weedwacker.GameServer.Data.BinOut.Talent.EquipTalents;
using Weedwacker.GameServer.Data.BinOut.Talent.RelicTalents;
using Weedwacker.GameServer.Data.BinOut.Talent.TeamTalents;
using Weedwacker.GameServer.Data.Common.ConfigTalentTypes;
using Weedwacker.GameServer.Data.Excel;
using static Weedwacker.GameServer.Data.SerializationSettings;

namespace Weedwacker.GameServer.Data
{
    internal static class GameData
    {
        //Avatar//
        //---------------------------------------------------------------------------------------------------------------------------------//
        public readonly static SortedList<int, AvatarCodexData> AvatarCodexDataMap = new(); // sortId
        public readonly static SortedList<int, AvatarCostumeData> AvatarCostumeDataMap = new(); // costumeId
        public readonly static SortedList<int, AvatarCurveData> AvatarCurveDataMap = new(); // level
        public readonly static SortedList<int, AvatarData> AvatarDataMap = new(); // AvatarId
        public readonly static SortedList<int, AvatarFetterLevelData> AvatarFetterLevelDataMap = new(); // level
        public readonly static SortedList<int, AvatarFlycloakData> AvatarFlycloakDataMap = new(); // flycloakId
        public readonly static SortedList<int, AvatarLevelData> AvatarLevelDataMap = new(); // Level
        public readonly static SortedList<Tuple<int, int>, AvatarPromoteData> AvatarPromoteDataMap = new(); // <<PromoteId,promoteLevel>,Data>
        public readonly static SortedList<int, AvatarSkillData> AvatarSkillDataMap = new(); // SkillId
        public readonly static SortedList<int, AvatarSkillDepotData> AvatarSkillDepotDataMap = new(); // SkillDepotId
        public readonly static SortedList<string, AvatarTalentConfigData> AvatarTalentConfigDataMap = new(); // openConfig
        public readonly static SortedList<int, AvatarTalentData> AvatarTalentDataMap = new(); // talentId
        public readonly static SortedList<int, FetterCharacterCardData> FetterCharacterCardDataMap = new(); // avatarId
        public readonly static SortedList<int, FetterInfoData> FetterInfoDataMap = new(); // fetterId
        public readonly static SortedList<int, FettersData> FettersDataMap = new(); // fetterId
        public readonly static SortedList<int, FetterStoryData> FetterStoryDataMap = new(); // fetterId
        public readonly static SortedList<int, PhotographExpressionData> PhotographExpressionDataMap = new(); // fetterId
        public readonly static SortedList<int, PhotographPosenameData> PhotographPosenameDataMap = new(); // fetterId
        public readonly static SortedList<string, PlayerElementAbilityData> PlayerElementAbilityDataMap = new(); //skillDepotAbilityGroup
        public readonly static SortedList<int, ProudSkillData> ProudSkillDataMap = new(); // proudSkillId
        //---------------------------------------------------------------------------------------------------------------------------------//

        public readonly static SortedList<int, DungeonData> DungeonDataMap = new(); // id
        public readonly static SortedList<int, EnvAnimalGatherData> EnvAnimalGatherDataMap = new(); // animalId
        public readonly static SortedList<int, EquipAffixData> EquipAffixDataMap = new(); // affixId
        public readonly static SortedList<int, GatherData> GatherDataMap = new(); // id
        public readonly static SortedList<int, GadgetData> GadgetDataMap = new(); // id
        public readonly static SortedList<int, HomeWorldFurnitureData> HomeWorldFurnitureDataMap = new(); // id
        public readonly static SortedList<int, ItemData> ItemDataMap = new(); // id ItemData is subclassed, and loaded as MaterialData, ReliquaryData, and WeaponData
        public readonly static SortedList<int, MonsterCurveData> MonsterCurveDataMap = new(); // level
        public readonly static SortedList<int, MonsterData> MonsterDataMap = new(); // id
        public readonly static SortedList<int, MonsterDescribeData> MonsterDescribeDataMap = new(); // id
        public readonly static SortedList<string, RelicAffixConfigData> RelicAffixConfigDataMap = new(); // openConfig
        public readonly static SortedList<int, RewardData> RewardDataMap = new(); // RewardId
        public readonly static SortedList<string, TeamResonanceConfigData> TeamResonanceConfigDataMap = new(); // openConfig
        public readonly static SortedList<string, WeaponAffixConfigData> WeaponAffixConfigDataMap = new(); // openConfig
        public readonly static SortedList<int, WeaponCurveData> WeaponCurveDataMap = new(); // level
        public readonly static SortedList<Tuple<int,int>, WeaponPromoteData> WeaponPromoteDataMap = new(); // <weaponPromoteId, promoteLevel>
        public readonly static SortedList<int, ReliquaryAffixData> ReliquaryAffixDataMap = new(); // id
        public readonly static SortedList<int, ReliquaryMainPropData> ReliquaryMainPropDataMap = new(); // id
        public readonly static SortedList<Tuple<int, int>, ReliquaryLevelData> ReliquaryLevelDataMap = new(); // <rank, level>
        public readonly static SortedList<int, ReliquarySetData> ReliquarySetDataMap = new(); // setid
        public readonly static SortedList<int, SceneData> SceneDataMap = new(); //id
        public readonly static SortedList<string, ScenePointData> ScenePointDataMap = new(); // filename
        public readonly static SortedList<int, TeamResonanceData> TeamResonanceDataMap = new(); // teamResonanceId 



        static readonly JsonSerializer Serializer = new();

        // To handle $type
        static JsonSerializerSettings settings = new()
        {
            TypeNameHandling = TypeNameHandling.Objects,
            SerializationBinder = new KnownTypesBinder
            {
                KnownTypes = new List<Type> { typeof(AddAbility), typeof(AddTalentExtraLevel), typeof(ModifyAbility),
                    typeof(ModifySkillCD), typeof(ModifySkillPoint), typeof(UnlockTalentParam), typeof(DungeonEntry), typeof(DungeonExit), typeof(SceneTransPoint) }
            }
        };
    
        static async Task LoadFolder<Obj, Key>(string path, Func<Obj, Key> keySelector, SortedList<Key, Obj> map) where Key : notnull
        {
            string[] filePaths = Directory.GetFiles(path, ".json", SearchOption.TopDirectoryOnly);
            var tasks = new List<Task>();
            foreach (string filePath in filePaths) { tasks.Add(LoadData(filePath, keySelector, map)); }
            await Task.WhenAll(tasks);
        }

        // To handle derived types
        static async Task LoadData<Obj, Key, DerivedType>(string path, Func<Obj, Key> keySelector, SortedList<Key, Obj> map) where Key : notnull where DerivedType : Obj
        {
            var ra = typeof(DerivedType).GetResourceData();
            if (ra == null || !ra.GetResourceFile(path, out var fi)) return;
            map.Clear();
            var objs = await LoadObjects<DerivedType[]>(fi);
            if (objs == null) return;
            foreach (var obj in objs)
                map.Add(keySelector(obj), obj);
        }
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
        public static async Task LoadAllResourcesAsync(string resourcesPath)
        {
            string excelPath = Path.Combine(resourcesPath, "ExcelBinOutput");
            string binPath = Path.Combine(resourcesPath, "BinOutput");
            await Task.WhenAll(new Task[]
            {

                LoadData(excelPath, o => o.sortId, AvatarCodexDataMap),
                LoadData(excelPath, o => o.skinId, AvatarCostumeDataMap),
                LoadData(excelPath, o => o.level, AvatarCurveDataMap),
                LoadData(excelPath, o => o.id, AvatarDataMap),
                LoadData(excelPath, o => o.fetterLevel, AvatarFetterLevelDataMap),
                LoadData(excelPath, o => o.flycloakId, AvatarFlycloakDataMap),
                LoadData(excelPath, o => o.Level, AvatarLevelDataMap),
                LoadData(excelPath, o => Tuple.Create(o.avatarPromoteId, o.promoteLevel), AvatarPromoteDataMap),
                LoadData(excelPath, o => o.id, AvatarSkillDataMap),
                LoadData(excelPath, o => o.id, AvatarSkillDepotDataMap),
                LoadData(excelPath, o => o.talentId, AvatarTalentDataMap),
                LoadData(excelPath, o => o.id, DungeonDataMap),
                LoadData(excelPath, o => o.animalId, EnvAnimalGatherDataMap),
                LoadData(excelPath, o => o.affixId, EquipAffixDataMap),
                LoadData(excelPath, o => o.avatarId, FetterCharacterCardDataMap),
                LoadData(excelPath, o => o.fetterId, FetterInfoDataMap),
                LoadData(excelPath, o => o.fetterId, FettersDataMap),
                LoadData(excelPath, o => o.fetterId, FetterStoryDataMap),
                LoadData(excelPath, o => o.id, GatherDataMap),
                LoadData(excelPath, o => o.id, GadgetDataMap),
                LoadData(excelPath, o => o.id, HomeWorldFurnitureDataMap),
                LoadData<ItemData, int, MaterialData>(excelPath, o => o.id, ItemDataMap),
                LoadData(excelPath, o => o.level, MonsterCurveDataMap),
                LoadData(excelPath, o => o.id, MonsterDataMap),
                LoadData(excelPath, o => o.id, MonsterDescribeDataMap),
                LoadData(excelPath, o => o.fetterId, PhotographExpressionDataMap),
                LoadData(excelPath, o => o.fetterId, PhotographPosenameDataMap),
                LoadData(excelPath, o => o.proudSkillId, ProudSkillDataMap),
                LoadData<ItemData, int, ReliquaryData>(excelPath, o => o.id, ItemDataMap),
                LoadData(excelPath, o => o.id, ReliquaryAffixDataMap),
                LoadData(excelPath, o => o.id, ReliquaryMainPropDataMap),
                LoadData(excelPath, o => Tuple.Create(o.rank, o.level), ReliquaryLevelDataMap),
                LoadData(excelPath, o => o.setId, ReliquarySetDataMap),
                LoadData(excelPath, o => o.rewardId, RewardDataMap),
                LoadData(excelPath, o => o.id, SceneDataMap),
                LoadData(excelPath, o => o.teamResonanceId, TeamResonanceDataMap),
                LoadData<ItemData, int, WeaponData>(excelPath, o => o.id, ItemDataMap),
                LoadData(excelPath, o => o.level, WeaponCurveDataMap),
                LoadData(excelPath, o => Tuple.Create(o.weaponPromoteId, o.promoteLevel), WeaponPromoteDataMap),
                //LoadData(Path.Combine(binPath, "/AbilityGroup"), o => ????, PlayerElementAbilityDataMap), // TODO
                //LoadFolder(Path.Combine(binPath, "/AbilityGroup/Talent/AvatarTalents"), o => ????, AvatarTalentConfigDataMap),
                //LoadFolder(Path.Combine(binPath, "/AbilityGroup/Talent/EquipTalents"), o => ????, WeaponAffixConfigDataMap),
                //LoadFolder(Path.Combine(binPath, "/AbilityGroup/Talent/RelicTalents"), o => ????, RelicAffixConfigDataMap),
                //LoadFolder(Path.Combine(binPath, "/AbilityGroup/Talent/TeamTalents"), o => ????, TeamResonanceConfigDataMap),
                //LoadFolder(Path.Combine(binPath, "/Scene/Point"), o => ????, ScenePointDataMap)
            });
        }
    }
}
