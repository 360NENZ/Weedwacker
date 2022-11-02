using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class RemoveVelocityForce : BaseAction
    {
        [JsonProperty] public readonly VelocityForceType[] forces;
    }
}
