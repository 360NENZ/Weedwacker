using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    
    internal class ItemData
    {
        [JsonProperty]
        public readonly int id;
        [JsonProperty]
        public readonly int rank;
        [JsonProperty]
        public readonly long nameTextMapHash;
        [JsonProperty]
        public readonly long descTextMapHash;
        [JsonProperty]
        public readonly string icon;
        [JsonProperty]
        public readonly int rankLevel;
        [JsonProperty]
        public readonly DestroyRule destroyRule;
        [JsonProperty]
        public readonly int[]? destroyReturnMaterial;
        [JsonProperty]
        public readonly int[]? destroyReturnMaterialCount;
        [JsonProperty]
        public readonly ItemType itemType;
    }
}
