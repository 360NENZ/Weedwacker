using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common.ConfigTalentTypes
{
    internal class ModifySkillPoint : ConfigTalent
    {
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly int pointDelta;
    }
}
