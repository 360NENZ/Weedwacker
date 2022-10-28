using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class KillGadget : BaseAction
    {
        [JsonProperty] public readonly Info gadgetInfo;

        public class Info
        {
            [JsonProperty] public readonly int configID;
        }
    }
}
