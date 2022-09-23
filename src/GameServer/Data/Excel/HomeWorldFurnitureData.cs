using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("HomeWorldFurnitureExcelConfigData.json")]
    internal class HomeWorldFurnitureData : ItemData
    {
        /*
         * THE RESOURCE DATA
         * 
         * 
         * 
         *     IS KINDA
         * 
         * 
         *      JUNK
         */
        [JsonProperty]
        public readonly int comfort;
        [JsonProperty]
        public readonly string jsonName;
        [JsonProperty]
        public readonly int[]? furnType;
        [JsonProperty]
        public readonly int[]? furnitureGadgetID;

        //public readonly int roomSceneId;
    }
}
