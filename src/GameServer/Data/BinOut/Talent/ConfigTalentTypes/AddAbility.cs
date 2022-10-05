using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common.ConfigTalentTypes
{
    internal class AddAbility : ConfigTalent
    {
        [JsonProperty] public readonly string abilityName;
    }
}
