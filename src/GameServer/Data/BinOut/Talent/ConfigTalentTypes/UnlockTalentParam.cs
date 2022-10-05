using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common.ConfigTalentTypes
{
    internal class UnlockTalentParam : ConfigTalent
    {
        [JsonProperty] public readonly string abilityName;
        [JsonProperty] public readonly string talentParam;
    }
}
