using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.DirectionTypes
{
    internal class ConfigDirectionByAttachPoint : BaseDirectionType
    {
        [JsonProperty] public readonly string attachPointName;
        [JsonProperty] public readonly TargetType attachPointTargetType;
    }
}
