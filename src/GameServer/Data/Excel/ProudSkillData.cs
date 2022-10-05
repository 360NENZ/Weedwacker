using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ProudSkillExcelConfigData.json")]
    public class ProudSkillData
    {
        [JsonProperty]
        public readonly int proudSkillId;
        [JsonProperty]
        public readonly int proudSkillGroupId;
        [JsonProperty]
        public readonly int level;
        [JsonProperty]
        public readonly int coinCost;
        [JsonProperty]
        public readonly int breakLevel;
        [JsonProperty]
        public readonly int proudSkillType;
        [JsonProperty]
        public readonly string openConfig;
        [JsonProperty]
        public readonly string icon;
        [JsonProperty]
        public readonly List<ItemParamData> costItems;
        [JsonProperty]
        public readonly List<string> filterConds;
        [JsonProperty]
        public readonly List<string> lifeEffectParams;
        [JsonProperty]
        public readonly FightPropData[] addProps;
        [JsonProperty]
        public readonly double[] paramList;
        [JsonProperty]
        public readonly long[] paramDescList;
        [JsonProperty]
        public readonly long nameTextMapHash;

        public List<ItemParamData> GetTotalCostItems()
        {
            List<ItemParamData> total = new();
            total = (List<ItemParamData>)total.Concat(costItems);
            if (coinCost > 0)
                total.Add(new ItemParamData(202, coinCost));
            
            return total;
        }
    }
}
