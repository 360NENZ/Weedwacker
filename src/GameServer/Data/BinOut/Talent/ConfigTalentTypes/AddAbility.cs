using Newtonsoft.Json;
using Weedwacker.GameServer.Systems.Ability;
using Weedwacker.GameServer.Systems.Avatar;

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
