using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.BinOut.Talent.TeamTalents
{
    internal class TeamResonanceConfigData
    {
        [JsonProperty] public readonly Dictionary<string, ConfigTalent[]> Configs;
    }
}
