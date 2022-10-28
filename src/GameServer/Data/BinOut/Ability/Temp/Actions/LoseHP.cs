using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class LoseHP : BaseAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly float amountByTargetCurrentHPRatio;
        [JsonProperty] public readonly bool lethal;
        [JsonProperty] public readonly float limboByTargetMaxHPRatio;
    }
}
