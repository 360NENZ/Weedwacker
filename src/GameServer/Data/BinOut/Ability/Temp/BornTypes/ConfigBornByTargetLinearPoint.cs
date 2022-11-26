using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.BornTypes
{
    internal class ConfigBornByTargetLinearPoint : BaseBornType
    {
        [JsonProperty] public readonly float linearOffset;
        [JsonProperty] public readonly bool linearXZ;
        [JsonProperty] public readonly bool baseOnTarget;
    }
}
