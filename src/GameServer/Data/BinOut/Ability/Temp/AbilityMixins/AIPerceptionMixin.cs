using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AIPerceptionMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int perceptionTemplateID;
        [JsonProperty] public readonly int[] featureTagIDs;
    }
}
