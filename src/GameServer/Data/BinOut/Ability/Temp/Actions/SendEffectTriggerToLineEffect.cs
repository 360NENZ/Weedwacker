using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SendEffectTriggerToLineEffect : BaseAction
    {
        [JsonProperty] public readonly string parameter;
        [JsonProperty] public readonly string effectPattern;
    }
}
