using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class AddTalentExtraLevel : BaseConfigTalent
    {
        [JsonProperty] public readonly string talentType;
        [JsonProperty] public readonly int talentIndex;
        [JsonProperty] public readonly int extraLevel;
    }
}
