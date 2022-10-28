using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AttackPatterns
{
    internal class ConfigAttackBox : BaseAttackPattern
    {
        [JsonProperty] public readonly bool filterByFrame;
        [JsonProperty] public readonly Size size;

        public class Size
        {
            [JsonProperty] public readonly float x;
            [JsonProperty] public readonly float y;
            [JsonProperty] public readonly float z;
        }
    }
}
