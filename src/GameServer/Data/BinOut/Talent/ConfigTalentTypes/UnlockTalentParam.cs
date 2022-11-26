using Newtonsoft.Json;
using Weedwacker.GameServer.Systems.Ability;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class UnlockTalentParam : BaseConfigTalent
    {
        [JsonProperty] public readonly string abilityName;
        [JsonProperty] public readonly string talentParam;

        public override void Apply(BaseAbilityManager abilityManager, double[] paramList)
        {
            if (abilityManager.UnlockedTalentParams.ContainsKey(abilityName))
                abilityManager.UnlockedTalentParams[abilityName].Add(talentParam);
            else
            {
                abilityManager.UnlockedTalentParams[abilityName] = new() { talentParam };
            }
        }
    }
}
