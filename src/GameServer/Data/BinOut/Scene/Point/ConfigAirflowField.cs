using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point
{
    internal class ConfigAirflowField : BasePoint
    {
        [JsonProperty] public readonly float velocity;
        [JsonProperty] public readonly EffectType stayEffect;
        [JsonProperty] public readonly EffectType enterEffect;
    }
}
