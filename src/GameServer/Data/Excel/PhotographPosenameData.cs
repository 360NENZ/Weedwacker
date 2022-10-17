using Newtonsoft.Json;

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
        public readonly int avatarId;
    }
}
