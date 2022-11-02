using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ReviveStamina : BaseAction
    {
        [JsonProperty] public readonly object value;
    }
}
