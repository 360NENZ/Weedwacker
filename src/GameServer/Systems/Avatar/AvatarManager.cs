using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Database;

namespace Weedwacker.GameServer.Systems.Avatar
{
    // MongoDb collection: "avatars"
    internal class AvatarManager
    {
        [BsonId]
        [BsonElement("_id")]
        public int OwnerId { get; private set; } // GameUid
        [BsonDictionaryOptions(MongoDB.Bson.Serialization.Options.DictionaryRepresentation.ArrayOfDocuments)]
        [BsonElement] public Dictionary<int, Avatar> Avatars { get; private set; }
        [BsonIgnore] private Player.Player Owner; // Loaded by DatabaseManager
        [BsonIgnore]
        public Dictionary<ulong, Avatar> AvatarsGuid { get; private set; } = new();

        public AvatarManager(Player.Player owner)
        {
            OwnerId = owner.GameUid;
            Owner = owner;
            Avatars = new();
        }

        public async Task OnLoadAsync(Player.Player owner)
        {
            Owner = owner;
            var tasks = new List<Task>();
            foreach(Avatar avatar in Avatars.Values)
            {
                tasks.Add(avatar.OnLoadAsync(owner));
            }
            await Task.WhenAll(tasks);
            foreach (Avatar avatar in Avatars.Values)
            {
                AvatarsGuid.Add(avatar.Guid, avatar);
            }
        }
        public int GetAvatarCount()
        {
            return Avatars.Count;
        }


        public Avatar? GetAvatarById(int id)
        {
            return Avatars[id];
        }

        public Avatar? GetAvatarByGuid(ulong id)
        {
            return AvatarsGuid[id];
        }

        public bool HasAvatar(int id)
        {
            return Avatars.ContainsKey(id);
        }

        public async Task<bool> AddAvatar(Avatar avatar)
        {
            if (avatar.Data == null || HasAvatar(avatar.AvatarId))
            {
                return false;
            }

            // Put into maps
            Avatars.Add(avatar.AvatarId, avatar);
            AvatarsGuid.Add(avatar.Guid, avatar);
            var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update = Builders<AvatarManager>.Update.Set(w => w.Avatars[avatar.AvatarId], avatar);
            await DatabaseManager.UpdateAvatarsAsync(filter, update);

            return true; ;
        }
    }
}
