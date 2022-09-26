using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Database;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class AvatarManager
    {
        public int OwnerId { get; private set; }
        public Dictionary<int, Avatar.Avatar> Avatars { get; private set; }
        [BsonIgnore]
        private Player Owner; // Loaded by DatabaseManager
        [BsonIgnore]
        public Dictionary<long, Avatar.Avatar> AvatarsGuid { get; private set; } = new();

        public AvatarManager(Player owner)
        {
            OwnerId = owner.GameUid;
            Owner = owner;
            Avatars = new();
            DatabaseManager.CreateAvatarStorageAsync(owner);
        }

        public async Task OnLoadAsync(Player owner)
        {
            Owner = owner;
            var tasks = new List<Task>();
            foreach(Avatar.Avatar avatar in Avatars.Values)
            {
                tasks.Add(avatar.OnLoadAsync(owner));
            }
            await Task.WhenAll(tasks);
            foreach (Avatar.Avatar avatar in Avatars.Values)
            {
                AvatarsGuid.Add(avatar.Guid, avatar);
            }
        }
        public int GetAvatarCount()
        {
            return Avatars.Count;
        }


        public Avatar.Avatar? GetAvatarById(int id)
        {
            return Avatars[id];
        }

        public Avatar.Avatar? GetAvatarByGuid(long id)
        {
            return AvatarsGuid[id];
        }

        public bool HasAvatar(int id)
        {
            return Avatars.ContainsKey(id);
        }

        public async Task<bool> AddAvatar(Avatar.Avatar avatar)
        {
            if (avatar.Data == null || HasAvatar(avatar.AvatarId))
            {
                return false;
            }

            // Put into maps
            Avatars.Add(avatar.AvatarId, avatar);
            AvatarsGuid.Add(avatar.Guid, avatar);
            var updateQuery = new UpdateQueryBuilder<AvatarManager>();
            updateQuery.SetFilter(w => w.OwnerId == OwnerId);
            updateQuery.AddValueToSet(w => w.Avatars[avatar.AvatarId], avatar);
            Tuple<string,string> updateString = updateQuery.Build();
            var result = await DatabaseManager.UpdateAvatarsAsync(updateString);
            
            return result.IsAcknowledged;
        }
    }
}
