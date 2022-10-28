using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetAnimatorBool : BaseAction
    {
        [JsonProperty] public readonly string boolID;
    }
}
