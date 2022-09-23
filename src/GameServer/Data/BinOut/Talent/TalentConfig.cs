using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class TalentConfig
    {
        [JsonProperty]
        public readonly TalentConfigType type;
        [JsonProperty]
        public readonly string abilityName;
    }
}
