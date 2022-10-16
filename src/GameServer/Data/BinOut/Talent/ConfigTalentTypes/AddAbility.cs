using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class AddAbility : BaseConfigTalent
    {
        [JsonProperty] public readonly string abilityName;
    }
}
