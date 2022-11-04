using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class CameraBlurMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly Blur cameraRadialBlur;

        public class Blur
        {
            [JsonProperty] public readonly float power;
            [JsonProperty] public readonly float fadeTime;
        }
    }
}
