using System.Globalization;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ButtonHoldChargeMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly float chargeTime;
        [JsonProperty] public readonly object secondChargeTime;
        [JsonProperty] public double secondChargeTimeForRealNoCap { get; private set; }
        [JsonProperty] public readonly BaseAction[]? OnBeginUncharged;
        [JsonProperty] public readonly BaseAction[]? OnReleaseUncharged;
        [JsonProperty] public readonly BaseAction[]? OnBeginCharged;
        [JsonProperty] public readonly BaseAction[]? OnReleaseCharged;
        [JsonProperty] public readonly BaseAction[]? OnBeginSecondCharged;
        [JsonProperty] public readonly string[] chargeStateIDs;

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            if (secondChargeTime != null)
            {
                string val = secondChargeTime as string;
                if (string.IsNullOrEmpty(val))
                {
                    secondChargeTimeForRealNoCap = (double)secondChargeTime;                   
                }
                else
                {
                    secondChargeTimeForRealNoCap = 0.0f; //TODO
                }
            }
        }
    }
}
