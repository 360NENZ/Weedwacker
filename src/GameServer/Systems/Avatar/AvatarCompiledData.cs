using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.AbilityGroup;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Avatar
{
    // ONLY ONE INSTANCE PER AVATAR ID
    internal class AvatarCompiledData
    {
        public readonly AvatarData GeneralData;
        public readonly SortedList<int, AvatarSkillDepotData> SkillDepotData; // <depotId,depot> Skill, SubSkill, Talent, and ProudSkill ids. So far only the twins have multiple. Assume first is default
        public readonly SortedList<int,SortedList<int,AvatarSkillData>> SkillData; // <depotId,<skillId,data>>
        public readonly SortedList<int, AvatarPromoteData> PromoteData; // <promoteLevel,data> AKA Ascension
        public readonly SortedList<int, SortedList<int, AvatarTalentData>> TalentData; // <depotId,<talentId,data>> AKA Constellations
        public readonly SortedList<int, SortedList<int, ProudSkillData>> ProudSkillData; // <depotId,<proudSkillId,data>> Passives
        public readonly SortedList<int, int[]>? AbilityNameHashes; //<depotId,List<Hashes>>
        public readonly SortedList<int, AvatarCostumeData> CostumeData; // costumeId
        public readonly SortedList<int, AvatarCodexData> CodexData; // sortId Codex entry
        public static readonly SortedList<int, AvatarLevelData> LevelData = GameData.AvatarLevelDataMap; // <level,exp> Level exp breakpoints
        public static readonly SortedList<int, AvatarCurveData> CurveData = GameData.AvatarCurveDataMap; // <level,curveInfo> Base Stat multipliers
        public static readonly SortedList<int, AvatarFlycloakData> FlycloakData = GameData.AvatarFlycloakDataMap; // flycloakId

        // Fetters
        public readonly FetterCharacterCardData CardData;
        public readonly FetterInfoData FetterInfoData; // General info
        public readonly SortedList<int, FetterStoryData> FetterStoryData; // fetterId
        public readonly SortedList<int, FettersData> FettersData; // fetterId
        public readonly SortedList<int, PhotographPosenameData> PhotographPosenameData; // fetterId
        public readonly SortedList<int, PhotographExpressionData> PhotographExpressionData; // fetterId
        public static readonly SortedList<int, AvatarFetterLevelData> FetterLevelData = GameData.AvatarFetterLevelDataMap; // level Friendship exp breakpoints

        public readonly Tuple<ArithType, float>[] HpGrowthCurve;
        public readonly Tuple<ArithType, float>[] AttackGrowthCurve;
        public readonly Tuple<ArithType, float>[] DefenseGrowthCurve;



        public readonly List<int> Fetters;
        public readonly int NameCardRewardId;
        public readonly int NameCardId;
        public AvatarCompiledData(int avatarId)
        {
            GeneralData = GameData.AvatarDataMap[avatarId];
            if (GeneralData.candSkillDepotIds.Count() != 0)
            {
                SkillDepotData = new();
                foreach (int depotId in GeneralData.candSkillDepotIds)
                {
                    SkillDepotData.Add(depotId, GameData.AvatarSkillDepotDataMap[depotId]);
                }
            }
            else 
            {
                SkillDepotData = new() { { GeneralData.skillDepotId, GameData.AvatarSkillDepotDataMap[GeneralData.skillDepotId] } };
            }
            SkillData = new();
            PromoteData = new();
            TalentData = new();
            ProudSkillData = new();
            AbilityNameHashes = new();
            foreach (AvatarSkillDepotData depot in SkillDepotData.Values)
            {
                var dictionary = GameData.AvatarSkillDataMap.Where(w => depot.skills.Contains(w.Key) || depot.subSkills.Contains(w.Key)).ToDictionary(x => x.Key, x => x.Value);
                SkillData.Add(depot.id, new SortedList<int, AvatarSkillData>(dictionary));
                var dictionary9 = GameData.AvatarPromoteDataMap.Where(w => w.Key.Item1 == GeneralData.avatarPromoteId).ToDictionary(x => x.Key.Item2, x => x.Value);
                PromoteData = new SortedList<int, AvatarPromoteData>(dictionary9);
                var dictionary7 = GameData.AvatarTalentDataMap.Where(w => depot.talents.Contains(w.Value.talentId)).ToDictionary(x => x.Key, x => x.Value);
                TalentData.Add(depot.id, new SortedList<int, AvatarTalentData>(dictionary7));
                var dictionary8 = GameData.ProudSkillDataMap.Where(w => depot.inherentProudSkillOpens.Exists(y => y.proudSkillGroupId == w.Value.proudSkillGroupId)).ToDictionary(x => x.Key, x => x.Value);
                ProudSkillData.Add(depot.id, new SortedList<int, ProudSkillData>(dictionary8));

                // Set embryo abilities (if player skill depot)
                if (depot.skillDepotAbilityGroup != null && depot.skillDepotAbilityGroup.Length > 0)
                {
                    PlayerElementAbilityData abilityData = GameData.PlayerElementAbilityDataMap[depot.skillDepotAbilityGroup];

                    if (abilityData != null)
                    {
                        List<int> hashes = new();
                        foreach (PlayerElementAbilityData.TargetAbility ability in abilityData.targetAbilities)
                        {
                            hashes.Add(Utils.AbilityHash(ability.abilityName));
                        }
                        AbilityNameHashes.Add(depot.id, hashes.ToArray());
                    }
                }
            }
            var dictionary1 = GameData.AvatarCostumeDataMap.Where(w => w.Value.avatarId == GeneralData.id).ToDictionary(x => x.Key, x => x.Value);
            CostumeData = new SortedList<int, AvatarCostumeData>(dictionary1);
            var dictionary2 = GameData.AvatarCodexDataMap.Where(w => w.Value.avatarId == GeneralData.id).ToDictionary(x => x.Key, x => x.Value);
            CodexData = new SortedList<int, AvatarCodexData>(dictionary2);

            // Fetters
            CardData = GameData.FetterCharacterCardDataMap[avatarId];
            FetterInfoData = GameData.FetterInfoDataMap.Where(w => w.Value.avatarId == avatarId).FirstOrDefault().Value;
            var dictionary3 = GameData.FettersDataMap.Where(w => w.Value.avatarId == avatarId).ToDictionary(w => w.Key, w => w.Value);
            FettersData = new SortedList<int, FettersData>(dictionary3);
            var dictionary4 = GameData.FetterStoryDataMap.Where(w => w.Value.avatarId == avatarId).ToDictionary(w => w.Key, w => w.Value);
            FetterStoryData = new SortedList<int, FetterStoryData>(dictionary4);
            var dictionary5 = GameData.PhotographPosenameDataMap.Where(w => w.Value.avatarId == avatarId).ToDictionary(w => w.Key, w => w.Value);
            PhotographPosenameData = new SortedList<int, PhotographPosenameData>(dictionary5);
            var dictionary6 = GameData.PhotographExpressionDataMap.Where(w => w.Value.avatarId == avatarId).ToDictionary(w => w.Key, w => w.Value);
            PhotographExpressionData = new SortedList<int, PhotographExpressionData>(dictionary6);

            HpGrowthCurve = new Tuple<ArithType,float>[CurveData.Count];
            AttackGrowthCurve = new Tuple<ArithType, float>[CurveData.Count];
            DefenseGrowthCurve = new Tuple<ArithType, float>[CurveData.Count];
            foreach (AvatarCurveData curveData in CurveData.Values)
            {
                int level = curveData.level - 1;
                foreach (PropGrowCurve growCurve in GeneralData.propGrowCurves)
                {
                    switch (growCurve.type)
                    {
                        case FightProperty.FIGHT_PROP_BASE_HP:
                            HpGrowthCurve[level] = curveData.GetArith(growCurve.growCurve);
                            break;
                        case FightProperty.FIGHT_PROP_BASE_ATTACK:
                            AttackGrowthCurve[level] = curveData.GetArith(growCurve.growCurve);
                            break;
                        case FightProperty.FIGHT_PROP_BASE_DEFENSE:
                            DefenseGrowthCurve[level] = curveData.GetArith(growCurve.growCurve);
                            break;
                        default:
                            Logger.WriteErrorLine("Error loading Avatar Growth Curves");
                            break;
                    }
                }
            }
        }

        private static float CalcValue(float value, Tuple<ArithType,float> curve)
        {
            switch(curve.Item1)
            {
                case ArithType.ARITH_MULTI:
                    return value * curve.Item2;
                case ArithType.ARITH_ADD:
                    return value + curve.Item2;
                default:
                    Logger.WriteErrorLine("Unknown Avatar curve operation");
                    goto case ArithType.ARITH_MULTI;            
            }
        }
        public float GetBaseHp(int level)
        {
            try
            {
                return CalcValue(GeneralData.hpBase, HpGrowthCurve[level - 1]);
            }
            catch (Exception e)
            {
                return GeneralData.hpBase;
            }
        }

        public float GetBaseAttack(int level)
        {
            try
            {
                return CalcValue(GeneralData.attackBase, AttackGrowthCurve[level - 1]);
            }
            catch (Exception e)
            {
                return GeneralData.attackBase;
            }
        }

        public float GetBaseDefense(int level)
        {
            try
            {
                return CalcValue(GeneralData.defenseBase, DefenseGrowthCurve[level - 1]);
            }
            catch (Exception e)
            {
                return GeneralData.defenseBase;
            }
        }

        public float GetBaseCritical()
        {
            return GeneralData.critical;
        }

        public float GetBaseCriticalHurt()
        {
            return GeneralData.criticalHurt;
        }

    }
}
