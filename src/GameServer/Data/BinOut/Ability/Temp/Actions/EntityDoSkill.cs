using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EntityDoSkill : BaseAction
    {
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly bool isHold;
    }
}
