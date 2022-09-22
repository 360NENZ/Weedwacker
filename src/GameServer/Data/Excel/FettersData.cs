using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("FettersExcelConfigData.json")]
    internal class FettersData : FetterBaseClass
    {
        [JsonProperty]
        public readonly int initialFetterState;
        [JsonProperty]
        public readonly int[] costumeIds;
        [JsonProperty]
        public readonly int[] tips;
        [JsonProperty]
        public readonly long voiceTitleTextMapHash;
        [JsonProperty]
        public readonly int voiceFile;
        [JsonProperty]
        public readonly long voiceFileTextTextMapHash;
        [JsonProperty]
        public readonly long voiceTitleLockedTextMapHash;
        [JsonProperty]
        public new readonly int fetterId;
        [JsonProperty]
        public readonly int avatarId;
        [JsonProperty]
        public new readonly FetterCond[] openConds;
        [JsonProperty]
        public new readonly FetterCond[] finishConds;
    }
}
