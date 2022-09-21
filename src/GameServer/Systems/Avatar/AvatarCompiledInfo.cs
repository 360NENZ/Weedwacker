using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.AbilityGroup;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Avatar
{
    internal class AvatarCompiledInfo
    {
        public readonly AvatarData GeneralData;
        public readonly SortedList<int, AvatarSkillDepotData> SkillDepotData; // <depotId,depot> Skill, SubSkill, Talent, and ProudSkill ids. So far only the twins have multiple. Assume first is default
        public readonly SortedList<int,SortedList<int,AvatarSkillData>> SkillData; // <depotId,<skillId,data>>
        public readonly SortedList<int, SortedList<int, AvatarPromoteData>> PromoteData; // <depotId,<level,data>> AKA Ascension
        public readonly SortedList<int, SortedList<int, AvatarTalentData>> TalentData; // <depotId,<talentId,data>> AKA Constellations
        public readonly SortedList<int, SortedList<int, ProudSkillData>> ProudSkillData; // <depotId,<proudSkillId,data>> Passives
        public readonly SortedList<int,List<int>>? AbilityNameHashes; //<depotId,List<Hashes>>
        public readonly SortedList<int, AvatarCostumeData> CostumeData; // costumeId
        public readonly SortedList<int, AvatarCodexData> CodexData; // sortId Codex entry
        public static readonly SortedList<int, AvatarLevelData> LevelData = GameData.AvatarLevelDataMap; // <level,exp> Level exp breakpoints
        public static readonly SortedList<int, AvatarCurveData> CurveData = GameData.AvatarCurveDataMap; // <level,curveInfo> Base Stat multipliers
        public static readonly SortedList<int, AvatarFetterLevelData> FetterLevelData = GameData.AvatarFetterLevelDataMap; // level Friendship exp breakpoints
        public static readonly SortedList<int, AvatarFlycloakData> FlycloakData = GameData.AvatarFlycloakDataMap; // flycloakId

        public readonly double[] HpGrowthCurve;
        public readonly double[] AttackGrowthCurve;
        public readonly double[] DefenseGrowthCurve;



        public readonly List<int> Fetters;
        public readonly int NameCardRewardId;
        public readonly int NameCardId;
        public AvatarCompiledInfo(int avatarId)
        {
            GeneralData = GameData.AvatarDataMap[avatarId];
            if (GeneralData.candSkillDepotIds.Count != 0)
            {
                SkillDepotData = new();
                foreach (int depotId in GeneralData.candSkillDepotIds)
                {
                    SkillDepotData.Add(depotId, GameData.AvatarSkillDepotDataMap[depotId]);
                }
            }
            else 
            {
                SkillDepotData = new() { { 1, GameData.AvatarSkillDepotDataMap[GeneralData.skillDepotId] } };
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
                PromoteData.Add(depot.id, GameData.AvatarPromoteDataMap.Where(w => w.Key == GeneralData.avatarPromoteId).FirstOrDefault().Value);
                var dictionary2 = GameData.AvatarTalentDataMap.Where(w => depot.talents.Contains(w.Value.talentId)).ToDictionary(x => x.Key, x => x.Value);
                TalentData.Add(depot.id, new SortedList<int, AvatarTalentData>(dictionary2));
                var dictionary3 = GameData.ProudSkillDataMap.Where(w => depot.inherentProudSkillOpens.Exists(y => y.proudSkillGroupId == w.Value.proudSkillGroupId)).ToDictionary(x => x.Key, x => x.Value);
                ProudSkillData.Add(depot.id, new SortedList<int, ProudSkillData>(dictionary3));

                // Set embryo abilities (if player skill depot)
                if (depot.skillDepotAbilityGroup != null && depot.skillDepotAbilityGroup.Length > 0)
                {
                    PlayerElementAbilityData abilityData = GameData.PlayerElementAbilityMap[depot.skillDepotAbilityGroup];

                    if (abilityData != null)
                    {
                        List<int> hashes = new();
                        foreach (PlayerElementAbilityData.TargetAbility ability in abilityData.targetAbilities)
                        {
                            hashes.Add(Utils.AbilityHash(ability.abilityName));
                        }
                        AbilityNameHashes.Add(depot.id, hashes);
                    }
                }
            }
            var dictionary4 = GameData.AvatarCostumeDataMap.Where(w => w.Value.avatarId == GeneralData.id).ToDictionary(x => x.Key, x => x.Value);
            CostumeData = new SortedList<int, AvatarCostumeData>(dictionary4);
            var dictionary5 = GameData.AvatarCodexDataMap.Where(w => w.Value.avatarId == GeneralData.id).ToDictionary(x => x.Key, x => x.Value);
            CodexData = new SortedList<int, AvatarCodexData>(dictionary5);


            HpGrowthCurve = new double[CurveData.Count];
            AttackGrowthCurve = new double[CurveData.Count];
            DefenseGrowthCurve = new double[CurveData.Count];
            foreach (AvatarCurveData curveData in CurveData.Values)
            {
                int level = curveData.level - 1;
                foreach (PropGrowCurve growCurve in GeneralData.propGrowCurves)
                {
                    switch (growCurve.type)
                    {
                        case FightProperty.FIGHT_PROP_BASE_HP:
                            HpGrowthCurve[level] = curveData.GetMultiplier(growCurve.growCurve);
                            break;
                        case FightProperty.FIGHT_PROP_BASE_ATTACK:
                            AttackGrowthCurve[level] = curveData.GetMultiplier(growCurve.growCurve);
                            break;
                        case FightProperty.FIGHT_PROP_BASE_DEFENSE:
                            DefenseGrowthCurve[level] = curveData.GetMultiplier(growCurve.growCurve);
                            break;
                        default:
                            Logger.WriteErrorLine("Error loading Avatar Growth Curves");
                            break;
                    }
                }
            }
        }


        public double GetBaseHp(int level)
        {
            try
            {
                return GeneralData.hpBase * HpGrowthCurve[level - 1];
            }
            catch (Exception e)
            {
                return GeneralData.hpBase;
            }
        }

        public double GetBaseAttack(int level)
        {
            try
            {
                return GeneralData.attackBase * AttackGrowthCurve[level - 1];
            }
            catch (Exception e)
            {
                return GeneralData.attackBase;
            }
        }

        public double GetBaseDefense(int level)
        {
            try
            {
                return GeneralData.defenseBase * DefenseGrowthCurve[level - 1];
            }
            catch (Exception e)
            {
                return GeneralData.defenseBase;
            }
        }

        public double GetBaseCritical()
        {
            return GeneralData.critical;
        }

        public double GetBaseCriticalHurt()
        {
            return GeneralData.criticalHurt;
        }


        /*
        public IntStream getSkillsAndEnergySkill()
        {
            return IntStream.concat(this.skills.stream().mapToInt(i->i), IntStream.of(this.energySkill))
                            .filter(skillId->skillId > 0);
        }

        // Get fetters from GameData
        this.fetters = GameData.getFetterDataEntries().get(this.id);

        if (GameData.getFetterCharacterCardDataMap().get(this.id) != null)
        {
            this.nameCardRewardId = GameData.getFetterCharacterCardDataMap().get(this.id).getRewardId();
        }

        if (GameData.getRewardDataMap().get(this.nameCardRewardId) != null)
        {
            this.nameCardId = GameData.getRewardDataMap().get(this.nameCardRewardId).getRewardItemList().get(0).getItemId();
        }


        ProudSkillData public Iterable<ItemParamData> getTotalCostItems()
        {
            if (this.totalCostItems == null)
            {
                ArrayList<ItemParamData> total = (this.costItems != null) ? new ArrayList<>(this.costItems) : new ArrayList<>(1);
                if (this.coinCost > 0)
                    total.add(new ItemParamData(202, this.coinCost));
                this.totalCostItems = total;
                }
        return this.totalCostItems;
            }
        }*/
    }
}
