using Weedwacker.GameServer.Systems.Avatar;

namespace Weedwacker.GameServer.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task<string> OnAddAvatar(params string[] args) // AvatarId, GameUid
        {
            if (!int.TryParse(args[0], out int avatarId) ||
                !GameServer.AvatarInfo.ContainsKey(avatarId))
            {
                return "invalid avatar id";
            }
            if(!int.TryParse(args[1], out int guid) ||
                !GameServer.OnlinePlayers.ContainsKey(guid))
            {
                return "Player isn't online or doesn't exist";
            }
            var newAvatar = await Avatar.CreateAsync(avatarId, GameServer.OnlinePlayers[guid].Player);
            await GameServer.OnlinePlayers[guid].Player.Avatars.AddAvatar(newAvatar);
            return $"Added avatar {avatarId} to player {guid}";
        }
    }
}
