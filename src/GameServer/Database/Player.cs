using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet;
using Weedwacker.GameServer.Systems.Player;
//using Weedwacker.GameServer.Systems.Player;

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
        [BsonIgnore]
        public bool HasSentLoginPackets { get; private set; }
        public List<int> FlyCloakList { get; private set; } = new() { 140001 };
        public Dictionary<PlayerProperty, int> PlayerProperties;
        public readonly AvatarManager Avatars;
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

        public async Task SendPacketAsync(BasePacket packet)
        {
            await GameServer.OnlinePlayers[GameUid].SendPacketAsync(packet);
        }
    }
}
