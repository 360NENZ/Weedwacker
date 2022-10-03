
using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("WeaponExcelConfigData.json")]
    internal class WeaponData : ItemData
    {
        [JsonProperty]
        public readonly WeaponType weaponType;
        [JsonProperty]
        public readonly int weaponBaseExp;
        [JsonProperty]
        public readonly int[] skillAffix;
        [JsonProperty]
        public readonly List<WeaponProperty>? weaponProp;
        [JsonProperty]
        public readonly string awakenTexture;
        [JsonProperty]
        public readonly string awakenLightMapTexture;
        [JsonProperty]
        public readonly string awakenIcon;
        [JsonProperty]
        public readonly int awakenMaterial;
        [JsonProperty]
        public readonly int weaponPromoteId;
        [JsonProperty]
        public readonly int storyId;
        [JsonProperty]
        public readonly int[] awakenCosts;
        [JsonProperty]
        public readonly int gachaCardNameHashPre;
        [JsonProperty]
        public readonly int weight;
        [JsonProperty]
        public readonly int gadgetId;

        public class WeaponProperty
        {
            [JsonProperty]
            public readonly FightProperty propType;
            [JsonProperty]
            public readonly float initValue;
            [JsonProperty]
            public readonly GrowCurveType type;
        }
    }
}
