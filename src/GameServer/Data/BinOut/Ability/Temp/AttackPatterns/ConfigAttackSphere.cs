using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AttackPatterns
{
    internal class ConfigAttackSphere : BaseAttackPattern
    {
        [JsonProperty] public readonly object radius; //TODO string or float
        [JsonProperty] public readonly bool ignoreMassive;
    }
}
