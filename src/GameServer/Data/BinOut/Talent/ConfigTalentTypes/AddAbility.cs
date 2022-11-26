using Newtonsoft.Json;
using Weedwacker.GameServer.Systems.Ability;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class AddAbility : BaseConfigTalent
    {
        [JsonProperty] public readonly string abilityName;

        public override void Apply(BaseAbilityManager abilityManager, double[] paramList)
        {
            abilityManager.ActiveDynamicAbilities.Add(abilityName);
        }
    }
}
