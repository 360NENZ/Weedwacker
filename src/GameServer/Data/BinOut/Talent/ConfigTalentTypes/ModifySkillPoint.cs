using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class ModifySkillPoint : BaseConfigTalent
    {
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly int pointDelta;
    }
}
