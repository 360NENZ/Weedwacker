using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Database;

namespace Weedwacker.GameServer.Systems.Social
{
    internal class SocialManager
    {
        [BsonId][BsonElement("_id")] public int OwnerId { get; private set; }
        [BsonIgnore] private Player.Player Owner;
        [BsonSerializer(typeof(IntDictionarySerializer<Friendship>))]
        [BsonElement] public Dictionary<int, Friendship> Friends { get; private set; } = new(); // GameUid
        [BsonSerializer(typeof(IntDictionarySerializer<Friendship>))]
        [BsonElement] public Dictionary<int, Friendship> PendingRequests { get; private set; } = new(); // GameUid
        [BsonSerializer(typeof(IntDictionarySerializer<Friendship>))]
        [BsonElement] public Dictionary<int, Friendship> BlackList { get; private set; } = new(); // GameUid why does it use the same proto lol
        [BsonElement] public HashSet<int> EmojiIdList { get; private set; } = new();

        public SocialManager(Player.Player owner)
        {
            OwnerId = owner.GameUid;
            Owner = owner;
        }

        public Task OnLoadAsync(Player.Player owner)
        {
            Owner = owner;

            return Task.CompletedTask;
        }
    }
}
