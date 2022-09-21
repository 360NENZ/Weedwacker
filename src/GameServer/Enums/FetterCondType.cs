using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FetterCondType
    {
        // In no particular order
        FETTER_COND_NOT_OPEN,
        FETTER_COND_FINISH_PARENT_QUEST,
        FETTER_COND_FINISH_QUEST,
        FETTER_COND_PLAYER_BIRTHDAY,
        FETTER_COND_AVATAR_LEVEL,
        FETTER_COND_AVATAR_PROMOTE_LEVEL,
        FETTER_COND_FETTER_LEVEL,
        FETTER_COND_UNLOCK_TRANS_POINT,
    }
}
