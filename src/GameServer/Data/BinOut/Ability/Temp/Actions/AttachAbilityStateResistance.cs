using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AttachAbilityStateResistance : BaseAction
    {
        [JsonProperty] public readonly int resistanceListID;
    }
}
