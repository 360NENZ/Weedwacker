using Newtonsoft.Json;
using Weedwacker.GameServer.Systems.Ability;
using Weedwacker.GameServer.Systems.Avatar;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class ModifySkillCD : BaseConfigTalent
    {
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly float cdRatio;

        public override void Apply(BaseAbilityManager abilityManager, double[] paramList)
        {
            //TODO
        }
    }
}
