using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.BinOut.Talent.EquipTalents
{
    internal class WeaponAffixConfigData
    {
        [JsonProperty] public readonly Dictionary<string, ConfigTalent[]> Configs;
    }
}
