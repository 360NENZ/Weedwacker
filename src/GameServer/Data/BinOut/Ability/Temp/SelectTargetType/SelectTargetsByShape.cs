using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType
{
    internal class SelectTargetsByShape : BaseSelectTargetType
    {
        [JsonProperty] public readonly string shapeName;
        [JsonProperty] public readonly TargetType centerBasedOn;
        [JsonProperty] public readonly TargetType campTargetType;
        [JsonProperty] public readonly TargetType campBasedOn;
        [JsonProperty] public readonly int topLimit;
        [JsonProperty] public readonly object sizeRatio;
    }
}
