using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common
{
    public class TargetAbility
    {
        [JsonProperty]
        public readonly string abilityID;
        [JsonProperty]
        public readonly string abilityName;
        [JsonProperty]
        public readonly string abilityOverride;
    }
}
