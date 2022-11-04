namespace Weedwacker.GameServer.Enums
{
    public enum StaminaDelta
    {
        None = 0,

        CLIMBING = -150,
        CLIMB_START = -50,
        CLIMB_JUMP = -250,
        DASH = -180, // per second
        DASH_START = -180,
        CLAYMORE_CHARGED = -400, // per second
        CATALYST_CHARGED = -500,
        SWORD_CHARGED = -200,
        POLEARM_CHARGED = -250,
        FLY = -30, // per second
        // Slow swimming is handled per movement, not per second.
        // Arm movement frequency depends on gender/age/height.
        SKIFF_DASH = -204,
        SWIM_DASH_START = -20,
        SWIM_DASH = -102, // per second
        SWIMMING = -40, // PER MOVEMENT

        // restore per second
        POWERED_FLY = 250,
        POWERED_SKIFF = 250,
        RUN = 250,
        SKIFF = 250,
        STANDBY = 250,
        WALK = 250,
    }
}
