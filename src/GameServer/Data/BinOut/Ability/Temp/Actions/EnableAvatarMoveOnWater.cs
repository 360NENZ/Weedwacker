using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnableAvatarMoveOnWater : BaseAction
    {
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly bool canBeHandledOnRecover;
        [JsonProperty] public readonly bool? enable;
    }
}
