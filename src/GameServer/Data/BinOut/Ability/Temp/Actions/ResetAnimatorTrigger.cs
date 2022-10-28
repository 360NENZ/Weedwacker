using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ResetAnimatorTrigger : BaseAction
    {
        [JsonProperty] public readonly TriggerID triggerID;
    }
}
