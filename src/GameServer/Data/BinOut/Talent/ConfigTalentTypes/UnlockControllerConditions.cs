using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class UnlockControllerConditions : BaseConfigTalent
    {
        [JsonProperty] public readonly string conditionName;
    }
}
