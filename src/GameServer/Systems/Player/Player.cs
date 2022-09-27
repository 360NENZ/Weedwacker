using MongoDB.Bson.Serialization.Attributes;
using Vim.Math3d;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Player
{
    // MongoDb collection: "players"
    internal class Player
    {
        [BsonId]
        [BsonElement("_id")]
        public string AccountUid { get; private set; }
        [BsonElement] public int GameUid { get; private set; }
        [BsonElement] public string HeroName { get; private set; }
        [BsonElement] public string Nickname { get; private set; }
        [BsonElement] public string Signature { get; private set; }
        [BsonElement] public int NameCardId { get; private set; } = 210001;
        [BsonElement] public Vector3 Position { get; private set; }
        [BsonElement] public Vector3 Rotation { get; private set; }
        [BsonElement] public Tuple<int,int> Birthday { get; private set; } // <Date,Month>
        [BsonElement] public int HeadImage { get; private set; }
        public int NextResinRefresh;
        public int LastDailyReset;
        public Dictionary<PlayerProperty, int> PlayerProperties;
        [BsonIgnore] public PlayerPropertyManager PropManager;
        [BsonIgnore] public ResinManager ResinManager;
        [BsonIgnore] public Connection Session; // Set by HandleGetPlayerTokenReq
        [BsonIgnore] public string Token { get; set; } // Obtained and used When Logging in
        [BsonIgnore] public bool HasSentLoginPackets { get; private set; }
        [BsonIgnore] private long NextGuid = 0;
        [BsonIgnore] public AvatarManager Avatars { get; set; } // Loaded by DatabaseManager
        [BsonIgnore] public InventoryManager Inventory; // Loaded by DatabaseManager

        [BsonConstructor]
        public Player(string heroName, string accountUid, int gameUid)
        {
            HeroName = heroName;
            AccountUid = accountUid;
            GameUid = gameUid;
            PropManager = new(this);
            ResinManager = new(this);
            
        }

        public long GetNextGameGuid()
        {
            long nextId = ++NextGuid;
            return ((long)GameUid << 32) + nextId;
        }

        public async Task OnLoginAsync()
        {
            // Show opening cutscene if player has no avatars
            if (Avatars.GetAvatarCount() == 0)
            {
                await PropManager.SetPropertyAsync(PlayerProperty.PROP_PLAYER_RESIN, 160, false);

                // Pick character
                Session.State = SessionState.PICKING_CHARACTER;
                await Session.SendPacketAsync(new BasePacket(OpCode.DoSetPlayerBornDataNotify));
            }

            // Multiplayer setting
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_PLAYER_MP_SETTING_TYPE, (int)MpSettingType.EnterAfterApply, false);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_IS_MP_MODE_AVAILABLE, 1, false);

            await ResinManager.OnLoginAsync();
        }
      
        public async Task SendPacketAsync(BasePacket packet)
        {
            await Session.SendPacketAsync(packet);
        }

    }
}
