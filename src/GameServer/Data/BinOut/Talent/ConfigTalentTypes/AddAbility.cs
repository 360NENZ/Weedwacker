using Newtonsoft.Json;
using Weedwacker.GameServer.Systems.Avatar;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class AddAbility : BaseConfigTalent
    {
        [JsonProperty] public readonly string abilityName;

        public override void Apply(SkillDepot depot, double[] paramList)
        {
            depot.ActiveDynamicAbilities.Add(abilityName);
        }
    }
}
