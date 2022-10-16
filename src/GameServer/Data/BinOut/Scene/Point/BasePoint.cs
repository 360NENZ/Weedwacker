using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point
{
    internal abstract class BasePoint
    {
        [JsonProperty] public readonly int gadgetId;
        [JsonProperty] public readonly int areaId;
        [JsonProperty] public readonly int heightSpeed;
        [JsonProperty] public readonly Dictionary<string, float>? pos;
        [JsonProperty] public readonly Dictionary<string, float>? rot;
        [JsonProperty] public readonly Dictionary<string, float>? tranPos;
        [JsonProperty] public readonly Dictionary<string, float>? tranRot;
        [JsonProperty] public readonly bool unlocked;
        [JsonProperty] public readonly string? alias;
        [JsonProperty] public readonly MapVisibility mapVisibility;
        [JsonProperty] public readonly Dictionary<string, float>? size;
        [JsonProperty] public readonly string? titleTextId;
        [JsonProperty] public readonly bool forbidSimpleUnlock;
        [JsonProperty] public readonly bool removeEntityIfLocked;
        [JsonProperty] public readonly bool isForbidAvatarRevive;
        [JsonProperty] public readonly bool isForbidAvatarAutoUseSpring;
        [JsonProperty] public readonly int maxSpringVolume;
        [JsonProperty] public readonly int worktopGroupId;
        [JsonProperty] public readonly bool fireFieldEvent;
        [JsonProperty] public readonly PointType type;
        [JsonProperty] public readonly bool isModelHidden;
    }
}
