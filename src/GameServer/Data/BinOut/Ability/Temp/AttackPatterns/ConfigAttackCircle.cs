using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AttackPatterns
{
    internal class ConfigAttackCircle : BaseAttackPattern
    {
        [JsonProperty] public readonly object radius; //TODO float or ... object[] -_-
    }
}
