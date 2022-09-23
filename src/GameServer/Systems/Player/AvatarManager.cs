using Weedwacker.GameServer.Database;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class AvatarManager
    {
        private Database.Player Owner;
        private Dictionary<int, Database.Avatar> Avatars;
        private Dictionary<long, Database.Avatar> AvatarsGuid;

        public AvatarManager(Database.Player player)
        {

        }

        public int GetAvatarCount()
        {
            return Avatars.Count;
        }


        public Database.Avatar? GetAvatarById(int id)
        {
            return Avatars[id];
        }

        public Database.Avatar GetAvatarByGuid(long id)
        {
            return AvatarsGuid[id];
        }

        public bool HasAvatar(int id)
        {
            return Avatars.ContainsKey(id);
        }

        public bool AddAvatar(Database.Avatar avatar)
        {
            if (avatar.Data == null || HasAvatar(avatar.AvatarId))
            {
                return false;
            }

            // Put into maps
            Avatars.Add(avatar.AvatarId, avatar);
            AvatarsGuid.Add(avatar.Guid, avatar);

            return true;
        }
    }
}
