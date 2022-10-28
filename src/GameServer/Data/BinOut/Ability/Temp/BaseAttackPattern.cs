using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal abstract class BaseAttackPattern
    {
        [JsonProperty] public readonly TriggerType triggerType;
        [JsonProperty] public readonly BaseBornType born;
    }
}
