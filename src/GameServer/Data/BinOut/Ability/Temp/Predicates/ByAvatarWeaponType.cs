using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByAvatarWeaponType : BasePredicate
    {
        [JsonProperty] public readonly WeaponType[] weaponTypes;
    }
}
