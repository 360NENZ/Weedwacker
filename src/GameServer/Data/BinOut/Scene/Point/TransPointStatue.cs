using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point
{
    internal class TransPointStatue : TransPoint
    {
        [JsonProperty] public readonly int[] cutsceneList;        
        [JsonProperty] public readonly int npcId;
        [JsonProperty] public readonly bool groupLimit;

    }
}
