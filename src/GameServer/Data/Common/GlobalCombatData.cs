using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common
{
    internal class GlobalCombatData
    {
        [JsonProperty] public readonly DefaultAbilities defaultAbilities;

        public class DefaultAbilities
        {
            [JsonProperty] public readonly string monterEliteAbilityName;
            [JsonProperty] public readonly string[] nonHumanoidMoveAbilities;
            [JsonProperty] public readonly string[] levelDefaultAbilities;
            [JsonProperty] public readonly string[] levelElementAbilities;
            [JsonProperty] public readonly string[] levelItemAbilities;
            [JsonProperty] public readonly string[] levelSBuffAbilities;
            [JsonProperty] public readonly string[] defaultMPLevelAbilities;
            [JsonProperty] public readonly string[] defaultAvatarAbilities;
        }
    }
}
