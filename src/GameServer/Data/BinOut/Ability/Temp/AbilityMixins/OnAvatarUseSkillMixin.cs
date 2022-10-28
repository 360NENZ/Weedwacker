using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class OnAvatarUseSkillMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly BaseAction[] onTriggerSkill;
        [JsonProperty] public readonly float clearSkillIdDelay;
    }
}
