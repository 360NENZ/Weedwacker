using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarCostumeExcelConfigData.json")]
    public class AvatarCostumeData
    {
        [JsonProperty]
        public readonly int skinId;
        [JsonProperty]
        public readonly int itemId;
        [JsonProperty]
        public readonly int avatarId;
    }
}