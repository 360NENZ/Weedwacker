using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.BinOut.Talent.RelicTalents
{
    internal class RelicAffixConfigData
    {
        [JsonProperty] public readonly Dictionary<string, ConfigTalent[]> Configs;
    }
}
