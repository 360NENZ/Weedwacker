using System.Globalization;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common.ConfigTalentTypes
{
    internal class ModifyAbility : ConfigTalent
    {
        [JsonProperty] public readonly string abilityName;
        [JsonProperty] public readonly string paramSpecial;
        [JsonProperty] public readonly object paramDelta;
        [JsonProperty] public readonly float paramRatio;
        [JsonProperty] public float paramDeltaUseThisDudeTrustMe { get; private set; }

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            string val = paramDelta as string;
            if (string.IsNullOrEmpty(val))
            {
                paramDeltaUseThisDudeTrustMe = (float)paramDelta;
            }
            else
            {
                var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                culture.NumberFormat.NumberDecimalSeparator = ".";
                string newString = Regex.Replace((string)paramDelta, "(%)", "");
                paramDeltaUseThisDudeTrustMe = float.Parse(newString, culture)/100;
            }
        }
    }
}
