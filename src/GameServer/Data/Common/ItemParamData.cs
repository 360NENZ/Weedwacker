using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
