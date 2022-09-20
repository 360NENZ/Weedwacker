﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarCostumeExcelConfigData.json")]
    public class AvatarCostumeData : GameResource
    {
        [JsonProperty]
        public readonly int costumeId;
        [JsonProperty]
        public readonly int itemId;
        [JsonProperty]
        public readonly int avatarId;
    }
}