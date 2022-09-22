using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("PhotographPosenameExcelConfigData.json")]
    internal class PhotographPosenameData : FetterBaseClass
    {
        [JsonProperty]
        public readonly string poseFile;
        [JsonProperty]
        public readonly string poseIcon;
        [JsonProperty]
        public readonly long poseNameTextMapHash;
        [JsonProperty]
        public readonly long unlockDescTextMapHash;
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
