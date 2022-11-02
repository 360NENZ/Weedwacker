using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AddAvatarSkillInfo : BaseAction
    {
        [JsonProperty] public readonly int overtime;
    }
}
