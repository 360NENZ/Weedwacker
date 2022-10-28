using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerBullet : BaseAction
    {
        [JsonProperty] public readonly int bulletID;
        [JsonProperty] public readonly BaseBornType born;
        [JsonProperty] public readonly BaseDirectionType direction;
    }
}
