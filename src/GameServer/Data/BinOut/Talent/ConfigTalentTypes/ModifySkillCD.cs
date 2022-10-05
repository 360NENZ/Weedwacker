using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common.ConfigTalentTypes
{
    internal class ModifySkillCD : ConfigTalent
    {
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly float cdRatio;
    }
}
