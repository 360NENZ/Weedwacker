using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType
{
    internal class SelectTargetsByEquipParts : BaseSelectTargetType
    {
        [JsonProperty] public readonly string[] equipPartNames;
    }
}
