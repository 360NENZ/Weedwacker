using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByLocalAvatarStamina : BasePredicate
    {
        [JsonProperty] public readonly LogicType logic;
        [JsonProperty] public readonly object stamina;
    }
}
