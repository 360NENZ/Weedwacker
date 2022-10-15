using MongoDB.Bson.Serialization.Attributes;

namespace Weedwacker.GameServer.Systems.Social
{
    internal class SocialManager
    {
        [BsonId][BsonElement("_id")] public int OwnerId { get; private set; }
        [BsonIgnore] private Player.Player Owner;
        [BsonDictionaryOptions(MongoDB.Bson.Serialization.Options.DictionaryRepresentation.ArrayOfDocuments)]
        [BsonElement] public Dictionary<int, Friendship> Friends { get; private set; } = new(); // GameUid
        [BsonElement] public List<int> BlackList { get; private set; } = new(); // GameUid

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
