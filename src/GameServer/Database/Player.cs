using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Systems.Player;

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
        [BsonIgnore]
        public string Token { get; set; } // Obtained and used When Logging in
        //public readonly AvatarManager Avatars;
        public Player(string heroName, string accountUid, int gameUid)
        {
            HeroName = heroName;
            AccountUid = accountUid;
            GameUid = gameUid;
            Avatars = new AvatarManager(this);
        }

        public void OnLogin()
        {

        }
    }
}
