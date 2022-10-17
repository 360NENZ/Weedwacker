using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("FetterInfoExcelConfigData.json")]
    internal class FetterInfoData : FetterBaseClass
    {
        [JsonProperty]
        public readonly int infoBirthMonth;
        [JsonProperty]
        public readonly int infoBirthDay;
        [JsonProperty]
        public readonly long avatarNativeTextMapHash;
        [JsonProperty]
        public readonly long avatarVisionBeforTextMapHash;
        [JsonProperty]
        public readonly long avatarConstellationBeforTextMapHash;
        [JsonProperty]
        public readonly long avatarTitleTextMapHash;
        [JsonProperty]
        public readonly long avatarDetailTextMapHash;
        [JsonProperty]
        public readonly string avatarAssocType;
        [JsonProperty]
        public readonly long cvChineseTextMapHash;
        [JsonProperty]
        public readonly long cvJapaneseTextMapHash;
        [JsonProperty]
        public readonly long cvEnglishTextMapHash;
        [JsonProperty]
        public readonly long cvKoreanTextMapHash;
        [JsonProperty]
        public readonly long avatarVisionAfterTextMapHash;
        [JsonProperty]
        public readonly long avatarConstellationAfterTextMapHash;
        [JsonProperty]
        public readonly int avatarId;
    }
}
