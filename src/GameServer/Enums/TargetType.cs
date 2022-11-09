using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TargetType
    {
        None,
        Owner,
        All,
        AllExceptSelf,
        Applier,
        Alliance,
        CurTeamAvatars,
        AllPlayerAvatars,
        Self,
        SelfAttackTarget,
        SelfCamp,
        OriginOwner,
        Caster,
        Other,
        Team,
        Enemy,
        Target,
    }
}
