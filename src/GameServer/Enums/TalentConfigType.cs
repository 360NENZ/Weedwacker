using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TalentConfigType
    {
        AddAbility,
        ModifyAbility,
        ModifySkillPoint,
        ModifySkillCD,
        UnlockTalentParam,
        AddTalentExtraLevel
    }
}
