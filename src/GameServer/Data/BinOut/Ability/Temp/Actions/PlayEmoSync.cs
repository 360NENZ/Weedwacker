using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class PlayEmoSync : BaseAction
    {
        [JsonProperty] public readonly string emoSyncAssetPath;
    }
}
