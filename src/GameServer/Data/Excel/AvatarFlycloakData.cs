using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarFlycloakExcelConfigData.json")]
    public class AvatarFlycloakData
    {
        [JsonProperty]
        public readonly int flycloakId;
        [JsonProperty]
        public readonly long nameTextMapHash;
        [JsonProperty]
        public readonly int materialId;

    }
}
