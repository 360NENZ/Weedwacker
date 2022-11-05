using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("TeamResonanceExcelConfigData.json")]
    internal class TeamResonanceData
    {
        [JsonProperty] public readonly int teamResonanceId;
        [JsonProperty] public readonly int teamResonanceGroupId;
        [JsonProperty] public readonly int level;
        [JsonProperty] public readonly int? fireAvatarCount;
        [JsonProperty] public readonly int? waterAvatarCount;
        [JsonProperty] public readonly int? windAvatarCount;
        [JsonProperty] public readonly int? electricAvatarCount;
        [JsonProperty] public readonly int? grassAvatarCount;
        [JsonProperty] public readonly int? iceAvatarCount;
        [JsonProperty] public readonly int? rockAvatarCount;
        [JsonProperty] public readonly string? cond;
        [JsonProperty] public readonly long nameTextMapHash;
        [JsonProperty] public readonly long descTextMapHash;
        [JsonProperty] public readonly string openConfig;
        //[JsonProperty] public readonly int[] addProps; unused?
        [JsonProperty] public readonly float[] paramList;
    }
}
