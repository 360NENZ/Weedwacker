using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.BinOut.Avatar
{
    internal class ConfigAvatar
    {
        [JsonProperty] public readonly List<TargetAbility> abilities;
    }
}
