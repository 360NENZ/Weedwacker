﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("FetterStoryExcelConfigData.json")]
    internal class FetterStoryData : FetterBaseClass
    {
        [JsonProperty]
        public readonly long storyTitleTextMapHash;
        [JsonProperty]
        public readonly long storyContextTextMapHash;
        [JsonProperty]
        public readonly long storyTitle2TextMapHash;
        [JsonProperty]
        public readonly long storyContext2TextMapHash;
        [JsonProperty]
        public readonly long[] tips;
        [JsonProperty]
        public readonly long storyTitleLockedTextMapHash;
        [JsonProperty]
        public readonly int avatarId;
    }
}
