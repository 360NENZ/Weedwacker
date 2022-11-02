using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetVelocityIgnoreAirGY : BaseAction
    {
        [JsonProperty] public readonly bool? ignoreAirGY;
        [JsonProperty] public readonly bool? doOffStage;
    }
}
