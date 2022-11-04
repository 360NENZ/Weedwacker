using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task<string> OnOpenState(params string[] args) // AvatarId, GameUid
        {
            if (!int.TryParse(args[0], out int openState) ||
                !Enum.IsDefined(typeof(OpenStateType), openState))
            {
                return "invalid openstate id";
            }
            if (!int.TryParse(args[1], out int guid) ||
                !GameServer.OnlinePlayers.ContainsKey(guid))
            {
                return "Player isn't online or doesn't exist";
            }
            await GameServer.OnlinePlayers[guid].Player.OpenStateManager.SetOpenStateAsync(openState, 1);
            return $"Set openstate {openState} for player {guid}";
        }
    }
}
