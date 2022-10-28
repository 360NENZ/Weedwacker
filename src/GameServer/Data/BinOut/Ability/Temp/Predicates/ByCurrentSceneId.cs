using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByCurrentSceneId : BasePredicate
    {
        [JsonProperty] public readonly int[] sceneIds;
    }
}
