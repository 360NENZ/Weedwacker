using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class UnlockTalentParam : BaseConfigTalent
    {
        [JsonProperty] public readonly string abilityName;
        [JsonProperty] public readonly string talentParam;
    }
}
