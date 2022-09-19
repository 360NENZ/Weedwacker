using MongoDB.Bson.Serialization.Attributes;

namespace Weedwacker.GameServer.Database
{
    internal class Player
    {
        [BsonId]
        [BsonElement("_id")]
        public string AccountUid { get; private set; }
        public int GameUid { get; private set; }
        public string HeroName { get; private set; }
        public bool IsBanned { get; private set; }
        public string BanReason { get; private set; }
        public int BanEndTime { get; private set; }
        public int BanStartTime { get; private set; }

        public Player(string heroName, string accountUid, int gameUid)
        {
            HeroName = heroName;
            AccountUid = accountUid;
            GameUid = gameUid;
        }
    }
}
