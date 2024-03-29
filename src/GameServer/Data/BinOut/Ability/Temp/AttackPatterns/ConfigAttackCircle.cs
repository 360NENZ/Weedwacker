﻿using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AttackPatterns
{
    internal class ConfigAttackCircle : BaseAttackPattern
    {
        [JsonProperty] public readonly object radius;
        [JsonProperty] public readonly TriggerType? triggerType;
        [JsonProperty] public readonly BaseBornType? born;
        [JsonProperty] public readonly float? secondHeight;
    }
}
