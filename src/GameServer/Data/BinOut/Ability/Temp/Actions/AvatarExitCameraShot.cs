using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AvatarExitCameraShot : BaseAction
    {
        [JsonProperty] public readonly bool doOffStage;
    }
}
