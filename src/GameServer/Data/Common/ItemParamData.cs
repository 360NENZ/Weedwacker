using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common
{
    public class ItemParamData
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("itemId")]
        private int itemId { set { id = value; } }
        [JsonProperty("count")]
        public int count { get; set; }

        [JsonProperty("itemCount")]
        private int itemCount { set { count = value; } }

        public ItemParamData(int itemId, int count)
        {
            id = itemId;
            this.count = count;
        }
    }
}
