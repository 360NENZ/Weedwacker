namespace Weedwacker.GameServer.Enums
{
    public enum TeleportType
    {
        /**
         * There is no specified reason to teleport.
         */
        INTERNAL,

        /**
         * The player has asked to teleport to a waypoint.
         */
        WAYPOINT,

        /**
         * The player has asked to teleport using the map.
         */
        MAP,

        /**
         * The player has asked to teleport into a dungeon.
         */
        DUNGEON,

        /**
         * The player has asked to teleport using the command.
         */
        COMMAND
    }
}
