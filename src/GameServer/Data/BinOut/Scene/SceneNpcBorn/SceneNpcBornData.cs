using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.BinOut.Scene.SceneNpcBorn
{
    internal class SceneNpcBornData
    {
        [JsonProperty] public readonly int sceneId;
        [JsonProperty] public readonly BornPos[] bornPosList;
    }
}
