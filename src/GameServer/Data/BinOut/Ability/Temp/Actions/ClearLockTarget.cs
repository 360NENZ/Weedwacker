using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ClearLockTarget : BaseAction
    {
        [JsonProperty] public readonly bool onlyAvatar;
    }
}
