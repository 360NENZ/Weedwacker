using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarLevelExcelConfigData.json")]
    internal class AvatarLevelData
    {
        [JsonProperty]
        public readonly int Level;
        [JsonProperty]
        public readonly int Exp;
    }
}
