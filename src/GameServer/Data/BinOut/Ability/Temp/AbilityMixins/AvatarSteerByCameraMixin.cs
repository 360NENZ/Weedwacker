using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AvatarSteerByCameraMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] stateIDs;
    }
}
