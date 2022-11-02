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
            depot.UnlockedTalentParams[abilityName].Add(talentParam);
        }
    }
}
