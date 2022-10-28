using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetCameraLockTime : BaseAction
    {
        [JsonProperty] public readonly float lockTime;
    }
}
