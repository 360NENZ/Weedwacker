using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class HealHP : BaseAction
    {
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public object? amount;
    }
}
