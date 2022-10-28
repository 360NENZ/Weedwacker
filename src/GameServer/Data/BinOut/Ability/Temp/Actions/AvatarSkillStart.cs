using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AvatarSkillStart : BaseAction
    {
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly object cdRatio; //TODO string or float
        [JsonProperty] public readonly object costStaminaRatio; //TODO string or float
    }
}
