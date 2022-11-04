using Newtonsoft.Json;
using Weedwacker.GameServer.Systems.Avatar;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class UnlockTalentParam : BaseConfigTalent
    {
        [JsonProperty] public readonly string abilityName;
        [JsonProperty] public readonly string talentParam;

        public override void Apply(SkillDepot depot, double[] paramList)
        {
            if(depot.UnlockedTalentParams.ContainsKey(abilityName))
                depot.UnlockedTalentParams[abilityName].Add(talentParam);
            else
            {
                depot.UnlockedTalentParams[abilityName] = new() { talentParam };
            }
        }
    }
}
