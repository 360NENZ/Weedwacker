using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class RemoveAvatarSkillInfo : BaseAction
    {
        [JsonProperty] public readonly int overtime;
    }
}
