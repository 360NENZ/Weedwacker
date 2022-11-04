using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionByCreateGadgetMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly BaseAction[] actionQueue;
    }
}
