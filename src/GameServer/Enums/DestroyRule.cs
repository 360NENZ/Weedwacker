using Newtonsoft.Json;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DestroyRule
    {
        DESTROY_RETURN_MATERIAL,
    }
}
