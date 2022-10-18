using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("FettersExcelConfigData.json")]
    internal class FettersData : FetterBaseClass
    {
        [JsonProperty]
        public readonly int type;
        [JsonProperty]
        public readonly int[] costumeIds;
        [JsonProperty]
        public readonly long[] tips;
        [JsonProperty]
        public readonly long voiceTitleTextMapHash;
        [JsonProperty]
        public readonly int? voiceFile;
        [JsonProperty]
        public readonly long voiceFileTextTextMapHash;
        [JsonProperty]
        public readonly long voiceTitleLockedTextMapHash;
        [JsonProperty]
        public readonly int avatarId;
    }
}
