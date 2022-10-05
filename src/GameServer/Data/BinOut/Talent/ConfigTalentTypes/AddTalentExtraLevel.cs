using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common.ConfigTalentTypes
{
    internal class AddTalentExtraLevel : ConfigTalent
    {
        [JsonProperty] public readonly string talentType;
        [JsonProperty] public readonly int talentIndex;
        [JsonProperty] public readonly int extraLevel;
    }
}
