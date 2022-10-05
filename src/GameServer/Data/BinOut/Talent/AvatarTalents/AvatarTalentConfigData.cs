using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.BinOut.Talent.AvatarTalents
{
    internal class AvatarTalentConfigData
    {
        [JsonProperty] public readonly Dictionary<string, ConfigTalent[]> Configs;
    }
}
