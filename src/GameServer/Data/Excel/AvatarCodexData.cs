﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    internal class AvatarCodexData : GameResource
    {
        [JsonProperty]
        public readonly int sortId;
        [JsonProperty]
        public readonly int sortFactor;
        [JsonProperty]
        public readonly int avatarId;
        [JsonProperty]
        public readonly string beginTime;
    }
}
