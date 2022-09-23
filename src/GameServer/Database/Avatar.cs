using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Database
{
    internal class Avatar
    {
        [BsonId]
        public readonly ObjectId id;
        public readonly int OwnerId;   // Id of player that this avatar belongs to
        public readonly int BornTime;
        public readonly int AvatarId;           // Id of avatar
        [BsonIgnore]
        public Player Owner { get; private set; }
        [BsonIgnore]
        public AvatarCompiledData Data { get; private set; }
        [BsonIgnore]
        public long Guid { get; private set; }           // Player unique Avatar id. Generated each session

        public int Level = 1;
        public int Exp;
        public int PromoteLevel;
        public int Satiation; // ?
        public int SatiationPenalty; // ?
        public LifeState Life = LifeState.LIFE_ALIVE;
        public int CurrentDepotId { get; private set; }
        public Dictionary<int, SkillDepot> SkillDepots { get; private set; } = new();
        public readonly FetterSystem Fetters;
        public readonly Dictionary<EquipType, GameItem> Equips = new();
        public readonly Dictionary<FightProperty, float> FightProp = new();

        public int FlyCloak { get; private set; } = 140001;
        public int Costume { get; private set; }

        public Avatar(int avatarId, Player owner)
        {
            Data = GameServer.GetAvatarInfo(avatarId);
            
            if(Data.GeneralData.candSkillDepotIds.Count() > 0)
            {
                foreach(int depotId in Data.GeneralData.candSkillDepotIds)
                {
                    SkillDepots.Add(depotId, new SkillDepot(avatarId,depotId));
                }
            }
            else
            {
                SkillDepots.Add(Data.GeneralData.skillDepotId, new SkillDepot(avatarId, Data.GeneralData.skillDepotId));
            }
            CurrentDepotId = Data.GeneralData.skillDepotId;
            Fetters = new(avatarId);
            Owner = owner;
            OwnerId = owner.GameUid;
            BornTime = (int)(DateTimeOffset.Now.ToUnixTimeMilliseconds() / 1000);

            // Combat properties
            foreach(FightProperty property in (FightProperty[])Enum.GetValues(typeof(FightProperty)))
            {
                if ((int)property > 0 && (int)property < 3000) FightProp.Add(property, 0f);
            }

            // Set stats
            RecalcStats();
            SetCurrentHp(FightProp[FightProperty.FIGHT_PROP_MAX_HP]);
        }

        public void SetCurrentHp(float value)
        {
            FightProp[FightProperty.FIGHT_PROP_CUR_HP] = value;
        }
        public SkillDepot GetCurSkillDepot()
        {
            return SkillDepots[CurrentDepotId];
        }
        public async Task<bool> SetFlyCloak(int cloakId)
        {
            if (!Owner.FlyCloakList.Contains(cloakId))
            {
                return false;
            }
            FlyCloak = cloakId;
            // Update
            await Owner.SendPacketAsync(new PacketAvatarFlycloakChangeNotify(this));

            return true;
        }

        static public int GetMinPromoteLevel(int level)
        {
            if (level > 80)
            {
                return 6;
            }
            else if (level > 70)
            {
                return 5;
            }
            else if (level > 60)
            {
                return 4;
            }
            else if (level > 50)
            {
                return 3;
            }
            else if (level > 40)
            {
                return 2;
            }
            else if (level > 20)
            {
                return 1;
            }
            return 0;
        }

        public GameItem? GetWeapon()
        {
            return Equips[EquipType.EQUIP_WEAPON];
        }

        public void SetCurrentEnergy(float currentEnergy)
        {
            GetCurSkillDepot().Element.CurEnergy = currentEnergy;
            FightProp[GetCurSkillDepot().Element.CurEnergyProp] = currentEnergy;
            //TODO update database
        }

        public void AddToFightProperty(FightProperty prop, float value)
        {
            FightProp[prop] += value;
            //TODO update database
        }

        public async Task<bool> EquipRelic(ReliquaryItem item, bool shouldRecalc)
        {
            //TODO
            return false;
        }
        public async Task<bool> EquipWeapon(WeaponItem item, bool shouldRecalc)
        {
            //TODO
            return false;
        }

        public bool UnequipRelic(EquipType slot)
        {
            return false;
        }
        public bool UnequipWeapon(EquipType slot)
        {
            return false;
        }

        public async Task RecalcStats()
        {
            await RecalcStats(false);
        }

        public async Task RecalcStats(bool forceSendAbilityChange)
        {
            // Setup
            AvatarCompiledData data = GameServer.AvatarInfo[AvatarId];
            AvatarPromoteData promoteData = GameServer.AvatarInfo[AvatarId].PromoteData[data.GeneralData.avatarPromoteId][PromoteLevel];

            // Get hp percent, set to 100% if none
            float hpPercent = FightProp[FightProperty.FIGHT_PROP_MAX_HP] == 0 ? 1f : FightProp[FightProperty.FIGHT_PROP_CUR_HP] / FightProp[FightProperty.FIGHT_PROP_MAX_HP];

            // Store current energy value for later
            float currentEnergy =  FightProp[GetCurSkillDepot().Element.CurEnergyProp];

            // Clear properties
            foreach(FightProperty prop in FightProp.Keys)
            {
                FightProp[prop] = 0f;
            }

            // Base stats
            FightProp[FightProperty.FIGHT_PROP_BASE_HP] = data.GetBaseHp(Level);
            FightProp[FightProperty.FIGHT_PROP_BASE_ATTACK] = data.GetBaseAttack(Level);
            FightProp[FightProperty.FIGHT_PROP_BASE_DEFENSE] = data.GetBaseDefense(Level);
            FightProp[FightProperty.FIGHT_PROP_CRITICAL] = data.GetBaseCritical();
            FightProp[FightProperty.FIGHT_PROP_CRITICAL_HURT] = data.GetBaseCriticalHurt();
            FightProp[FightProperty.FIGHT_PROP_CHARGE_EFFICIENCY] = 1f;


            foreach(FightPropData fightPropData in promoteData.addProps)
            {
                 AddToFightProperty(fightPropData.propType, fightPropData.value);
            }

            // Set energy usage
            SetCurrentEnergy(currentEnergy);

            //TODO Artifacts, Weapons 

            // Proud skills
            foreach(ProudSkillData proudSkill in GetCurSkillDepot().InherentProudSkillOpens)
            {
                // Add properties from this proud skill to our avatar
                foreach(FightPropData prop in proudSkill.addProps)
                {
                    FightProp[prop.propType] += prop.value;
                }
            }

            // Set % stats
            FightProp[FightProperty.FIGHT_PROP_MAX_HP] =
                (FightProp[FightProperty.FIGHT_PROP_BASE_HP] * (1f + FightProp[FightProperty.FIGHT_PROP_HP_PERCENT])) + FightProp[FightProperty.FIGHT_PROP_HP];
            FightProp[FightProperty.FIGHT_PROP_CUR_ATTACK] = 
                FightProp[FightProperty.FIGHT_PROP_BASE_ATTACK] * (1f + FightProp[FightProperty.FIGHT_PROP_ATTACK_PERCENT]) + FightProp[FightProperty.FIGHT_PROP_ATTACK];
            FightProp[FightProperty.FIGHT_PROP_CUR_DEFENSE] =
                FightProp[FightProperty.FIGHT_PROP_BASE_DEFENSE] * (1f + FightProp[FightProperty.FIGHT_PROP_DEFENSE_PERCENT]) + FightProp[FightProperty.FIGHT_PROP_DEFENSE];

            // Set current hp
            FightProp[FightProperty.FIGHT_PROP_CUR_HP] = FightProp[FightProperty.FIGHT_PROP_MAX_HP] * hpPercent;

            // Packet
            if (Owner.HasSentLoginPackets)
            {
                // Update stats for client
                await Owner.SendPacketAsync(new PacketAvatarFightPropNotify(this));
                //TODO Update client abilities

            }
        }


        public AvatarInfo ToProto()
        {
            int fetterLevel = Fetters.FetterLevel;
            AvatarFetterInfo avatarFetter = new AvatarFetterInfo() { ExpLevel = (uint)fetterLevel };

            if (fetterLevel != 10)
            {
                avatarFetter.ExpNumber = (uint)Fetters.FetterExp;
            }
            else
            {
                avatarFetter.RewardedFetterLevelList.Add(10);
            }
            foreach (FetterData fetter in Fetters.FetterStates.Values)
            {
                avatarFetter.FetterList.Add(fetter);
            }

            AvatarInfo avatarInfo = new()
            {
                AvatarId = (uint)AvatarId,
                Guid = (uint)Guid,
                CostumeId = (uint)Costume,
                WearingFlycloakId = (uint)FlyCloak,
                FetterInfo = avatarFetter,
                BornTime = (uint)BornTime,
                SkillDepotId = (uint)CurrentDepotId,
                LifeState = (uint)Life,
                AvatarType = 1,
                CoreProudSkillLevel = GetCurSkillDepot().GetCoreProudSkillLevel()
            };

            foreach (ProudSkillData proud in GetCurSkillDepot().InherentProudSkillOpens)
            {
                avatarInfo.InherentProudSkillList.Add((uint)proud.proudSkillId);
            }
            foreach (AvatarTalentData talent in GetCurSkillDepot().Talents)
            {
                avatarInfo.TalentIdList.Add((uint)talent.talentId);
            }
            foreach (int skill in GetCurSkillDepot().GetSkillLevelMap().Keys)
            {
                avatarInfo.SkillLevelMap.Add((uint)skill, (uint)GetCurSkillDepot().GetSkillLevelMap()[skill]);
            }
            foreach (FightProperty prop in FightProp.Keys)
            {
                avatarInfo.FightPropMap.Add((uint)prop, FightProp[prop]);
            }
            //TODO ProudSkillExtraLevelMap, MaxChargeCount

            foreach (GameItem item in Equips.Values)
            {
                avatarInfo.EquipGuidList.Add((ulong)item.Guid);
            }

            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_LEVEL, new PropValue() { Type = (uint)PlayerProperty.PROP_LEVEL, Val = Level });
            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_EXP, new PropValue() { Type = (uint)PlayerProperty.PROP_EXP, Val = (uint)Exp });
            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_BREAK_LEVEL, new PropValue() { Type = (uint)PlayerProperty.PROP_BREAK_LEVEL, Val = (uint)PromoteLevel });
            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_VAL, new PropValue() { Type = (uint)PlayerProperty.PROP_SATIATION_VAL, Val = 0 });
            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_PENALTY_TIME, new PropValue() { Type = (uint)PlayerProperty.PROP_SATIATION_PENALTY_TIME, Val = 0 });

            return avatarInfo;
        }

        // used only in character showcase
        public ShowAvatarInfo ToShowAvatarInfoProto()
        {
            int fetterLevel = Fetters.FetterLevel;
            AvatarFetterInfo avatarFetter = new() { ExpLevel = (uint)fetterLevel };

            ShowAvatarInfo showAvatarInfo = new()
            {
                AvatarId = (uint)AvatarId,
                CostumeId = (uint)Costume,
                SkillDepotId = (uint)CurrentDepotId,
                CoreProudSkillLevel = GetCurSkillDepot().GetCoreProudSkillLevel(),
                FetterInfo = avatarFetter
            };
            foreach (AvatarTalentData talent in GetCurSkillDepot().Talents)
            {
                showAvatarInfo.TalentIdList.Add((uint)talent.talentId);
            }
            foreach (ProudSkillData proudSkill in GetCurSkillDepot().InherentProudSkillOpens)
            {
                showAvatarInfo.InherentProudSkillList.Add((uint)proudSkill.proudSkillId);
            }
            foreach (int skill in GetCurSkillDepot().GetSkillLevelMap().Keys)
            {
                showAvatarInfo.SkillLevelMap.Add((uint)skill, (uint)GetCurSkillDepot().GetSkillLevelMap()[skill]);
            }
            foreach (int groupId in GetCurSkillDepot().proudSkillExtraLevelMap.Keys)
            {
                showAvatarInfo.ProudSkillExtraLevelMap.Add((uint)groupId, (uint)GetCurSkillDepot().proudSkillExtraLevelMap[groupId]);
            }
            foreach (FightProperty prop in FightProp.Keys)
            {
                showAvatarInfo.FightPropMap.Add((uint)prop, FightProp[prop]);
            }


            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_LEVEL, new PropValue() { Type = (uint)PlayerProperty.PROP_LEVEL, Val = (uint)Level });
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_EXP, new PropValue() { Type = (uint)PlayerProperty.PROP_EXP, Val = (uint)Exp });
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_BREAK_LEVEL, new PropValue() { Type = (uint)PlayerProperty.PROP_BREAK_LEVEL, Val = (uint)PromoteLevel });
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_VAL, new PropValue() { Type = (uint)PlayerProperty.PROP_SATIATION_VAL, Val = (uint)Satiation });
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_PENALTY_TIME, new PropValue() { Type = (uint)PlayerProperty.PROP_SATIATION_VAL, Val = (uint)SatiationPenalty });
            int maxStamina = Owner.PlayerProperties(PlayerProperty.PROP_MAX_STAMINA);
            showAvatarInfo.PropMap.Add(PlayerProperty.PROP_MAX_STAMINA.getId(), new PropValue() { Type = (uint)PlayerProperty.PROP_MAX_STAMINA, maxStamina));

            foreach(EquipItem item in Equips.Values)
            {
                if (item.getItemType() == ItemType.ITEM_RELIQUARY)
                {
                    ReliquaryItem asRelic = (ReliquaryItem)item;
                    showAvatarInfo.EquipList.Add(new ShowEquip()
                    {
                        ItemId = (uint)item.ItemId,
                        Reliquary = asRelic.ToReliquaryProto()
                    });
                }
                else if (item.getItemType() == ItemType.ITEM_WEAPON)
                {
                    WeaponItem asWeapon = (WeaponItem)item;
                    showAvatarInfo.EquipList.Add(new ShowEquip()
                    {
                        ItemId = (uint)asWeapon.ItemId,
                        Weapon = asWeapon.ToWeaponProto()
                    });
                }
            }

            return showAvatarInfo;
        }


    }
}
