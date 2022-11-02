using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ChangeFollowDampTime : BaseAction
    {
        [JsonProperty] public readonly string effectPattern;
        [JsonProperty] public readonly float PositionDampTime;
    }
}
