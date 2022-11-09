using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnableHDMesh : BaseAction
    {
        [JsonProperty] public readonly bool enable;
        [JsonProperty] public readonly string hdMeshKey;
    }
}
