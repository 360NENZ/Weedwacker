using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("FetterCharacterCardExcelConfigData.json")]
    internal class FetterCharacterCardData : GameResource
    {
        [JsonProperty]
        public readonly int avatarId;
        [JsonProperty]
        public readonly int fetterLevel;
        [JsonProperty]
        public readonly int rewardId;
    }
}
