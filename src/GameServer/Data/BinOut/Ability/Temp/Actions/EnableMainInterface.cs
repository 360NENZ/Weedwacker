﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnableMainInterface : BaseAction
    {
        [JsonProperty] public readonly bool? doOffStage;
        [JsonProperty] public readonly bool? enable;
    }
}
