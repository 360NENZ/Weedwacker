using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnablePushColliderName : BaseAction
    {
        [JsonProperty] public readonly string[] pushColliderNames;
        [JsonProperty] public readonly bool setEnable;
    }
}
