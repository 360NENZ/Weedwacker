using System.Globalization;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class ModifyAbility : BaseConfigTalent
    {
        [JsonProperty] public readonly string abilityName;
        [JsonProperty] public readonly string paramSpecial;
        [JsonProperty] public readonly object? paramDelta;
        [JsonProperty] public readonly object? paramRatio;
        [JsonProperty] public double? paramDeltaUseThisDudeTrustMe { get; private set; }
        [JsonProperty] public double? paramRatioForReal { get; private set; }

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            if (paramDelta != null)
            {
                string val = paramDelta as string;
                if (string.IsNullOrEmpty(val))
                {
                    paramDeltaUseThisDudeTrustMe = (double)paramDelta;
                }
                else
                {
                    var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                    culture.NumberFormat.NumberDecimalSeparator = ".";
                    string newString = Regex.Replace((string)paramDelta, "(%)", "");
                    paramDeltaUseThisDudeTrustMe = double.Parse(newString, culture) / 100;
                }
            }

            if (paramRatio != null)
            {
                string val2 = paramRatio as string;
                if (string.IsNullOrEmpty(val2))
                {
                    paramDeltaUseThisDudeTrustMe = (double)paramRatio;
                }
                else
                {
                    var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                    culture.NumberFormat.NumberDecimalSeparator = ".";
                    string newString = Regex.Replace((string)paramRatio, "(%)", "");
                    paramDeltaUseThisDudeTrustMe = double.Parse(newString, culture) / 100;
                }
            }
        }
    }
}
