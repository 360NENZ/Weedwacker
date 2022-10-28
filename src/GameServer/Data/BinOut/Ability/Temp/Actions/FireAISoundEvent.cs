using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class FireAISoundEvent : BaseAction
    {
        [JsonProperty] public readonly float volume;
    }
}
