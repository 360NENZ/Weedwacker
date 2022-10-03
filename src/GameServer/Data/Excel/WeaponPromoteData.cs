using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("WeaponPromoteExcelConfigData.json")]
    internal class WeaponPromoteData
    {
        [JsonProperty] public readonly int weaponPromoteId;
        [JsonProperty] public readonly int promoteLevel;
        [JsonProperty] public readonly ItemParamData[] costItems;
        [JsonProperty] public readonly int coinCost;
        [JsonProperty] public readonly FightPropData[] addProps;
        [JsonProperty] public readonly int unlockMaxLevel;
        [JsonProperty] public readonly int requiredPlayerLevel;
    }
}
