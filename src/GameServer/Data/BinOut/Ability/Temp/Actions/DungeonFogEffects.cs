using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class DungeonFogEffects : BaseAction
    {
        [JsonProperty] public readonly bool muteRemoteAction;
        [JsonProperty] public readonly bool? enable;
        [JsonProperty] public readonly bool? doOffStage;
        [JsonProperty] public readonly string cameraFogEffectName;
        [JsonProperty] public readonly string playerFogEffectName;
    }
}