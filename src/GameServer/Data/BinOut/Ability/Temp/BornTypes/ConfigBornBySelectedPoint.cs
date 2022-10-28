using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.BornTypes
{
    internal class ConfigBornBySelectedPoint : BaseBornType
    {
        [JsonProperty] public readonly bool onGround;
    }
}
