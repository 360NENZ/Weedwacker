using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class LoseHP : BaseAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly object amountByTargetCurrentHPRatio;
        [JsonProperty] public readonly bool lethal;
        [JsonProperty] public readonly float? limboByTargetMaxHPRatio;

        public override async Task Execute(string abilityName, AvatarEntity avatar, GameEntity enemyTarget = null)
        {
            if (!doOffStage && avatar.Avatar.Owner.TeamManager.GetCurrentAvatarEntity() != avatar) return;

            float curHP;
            float maxHP;
            float newHP;
            switch(target)
            {
                case TargetType.Self:
                    curHP = avatar.FightProps[FightProperty.FIGHT_PROP_CUR_HP];
                    maxHP = avatar.FightProps[FightProperty.FIGHT_PROP_MAX_HP];
                    newHP = curHP - DynamicFloatHelper.ResolveDynamicFloat(amountByTargetCurrentHPRatio, avatar.Avatar, abilityName) * curHP;
                    if(limboByTargetMaxHPRatio != null)
                    {
                        newHP = Math.Max(newHP, (float)limboByTargetMaxHPRatio);
                    }
                    else if(newHP < 1f)
                    {
                        if (lethal)
                        {
                            await avatar.DamageAsync(curHP);
                            return;
                        }
                        else
                            newHP = 1;
                    }
                    await avatar.SetHealthAsync(newHP);
                    return;
            }
        }
    }
}
