using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TriggerID
    {
        None,
        AimEnd,
        Attack,
        AutoDefendTrigger,
        BornToClose,
        BornToOpen,
        Crow_Talent_C_ExtreAttack,
        DevilDash_Skin,
        Dice_Attack,
        DoSkill,
        ElementalBurst_Skin,
        EndHoldTrigger,
        GemStone_Impact,
        Mask_TriggerTalent,
        NextLoopTrigger,
        NextSkillTrigger,
        PRIVATE_DoLastSpecialExtra,
        PRIVATE_DoSpecialExtra,
        Skin_Strong,
        Trigger_Burst,
    }
}
