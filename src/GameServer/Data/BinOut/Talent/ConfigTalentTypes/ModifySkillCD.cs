using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class ModifySkillCD : BaseConfigTalent
    {
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly float cdRatio;
    }
}
