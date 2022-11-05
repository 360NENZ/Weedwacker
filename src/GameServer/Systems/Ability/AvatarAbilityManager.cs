using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.GameServer.Data.BinOut.Talent;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Ability
{
    internal class AvatarAbilityManager : BaseAbilityManager
    {
        protected override Dictionary<uint, ConfigAbility> ConfigAbilityHashMap => (Owner as AvatarEntity).Avatar.GetCurSkillDepot().Abilities;

        public override Dictionary<string, Dictionary<string, float>?>? AbilitySpecials => (Owner as AvatarEntity).Avatar.GetCurSkillDepot().AbilitySpecials;

        public override HashSet<string> ActiveDynamicAbilities => (Owner as AvatarEntity).Avatar.GetCurSkillDepot().ActiveDynamicAbilities;

        public override Dictionary<string, HashSet<string>> UnlockedTalentParams => (Owner as AvatarEntity).Avatar.GetCurSkillDepot().UnlockedTalentParams;

        public AvatarAbilityManager(AvatarEntity avatar) : base(avatar)
        {
        }

        public override void Initialize()
        {
            foreach (var proudSkill in (Owner as AvatarEntity).Avatar.GetCurSkillDepot().InherentProudSkillOpens)
            {
                if (proudSkill.openConfig == null || proudSkill.openConfig == "") continue;
                foreach (BaseConfigTalent config in (Owner as AvatarEntity).Avatar.Data.ConfigTalentMap[(Owner as AvatarEntity).Avatar.CurrentDepotId][proudSkill.openConfig])
                {
                    config.Apply(this, proudSkill.paramList);
                }
            }
            base.Initialize();
        }
        protected override void AddAbility(AbilityAppliedAbility ability)
        {
            base.AddAbility(ability);
        }

    }
}
