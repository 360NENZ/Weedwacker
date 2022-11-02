using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class HideUIBillBoard : BaseAction
    {
        [JsonProperty] public readonly bool hide;
    }
}
