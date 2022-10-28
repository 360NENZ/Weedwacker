using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType
{
    internal class SelectTargetsByChildren : BaseSelectTargetType
    {
        [JsonProperty] public readonly int configID;
    }
}
