using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Vim.Math3d;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet;
using Weedwacker.GameServer.Packet.Recv;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.World;
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
        [BsonElement] public PlayerProfile Profile;
        [BsonIgnore] public World.World? World;
        [BsonIgnore] public Scene? Scene { get; private set; }
        [BsonElement] public int SceneId { get; private set; }
        [BsonElement] public int RegionId { get; private set; }
        [BsonIgnore] public uint PeerId;
        [BsonIgnore] public Vector3 Position;
        [BsonIgnore] public Vector3 Rotation;
        // Quick Hack for mongodb
        [BsonElement("Position")] public float[] PositionArray { get => new[] { Position.X, Position.Y, Position.Z }; set => Position = new(value[0], value[1], value[2]); }
        [BsonElement("Rotation")] public float[] RotationArray { get => new[] { Rotation.X, Rotation.Y, Rotation.Z }; set => Rotation = new(value[0], value[1], value[2]); }
        public int NextResinRefresh;
        public int LastDailyReset;
        public Dictionary<PlayerProperty, int> PlayerProperties { get; set; } = new(); // SET ONLY THROUGH THE PROPMANAGER
        [BsonIgnore] public PlayerPropertyManager PropManager;
        [BsonIgnore] public ResinManager ResinManager;
        [BsonIgnore] public Connection? Session; // Set by HandleGetPlayerTokenReq
        [BsonIgnore] public string Token { get; set; } // Obtained and used When Logging in
        [BsonIgnore] public uint EnterSceneToken;
        [BsonIgnore] private bool Paused;
        [BsonIgnore] public bool HasSentLoginPackets { get; private set; }
        [BsonIgnore] private ulong NextGuid = 0;
        [BsonIgnore] public SceneLoadState SceneLoadState = SceneLoadState.NONE;
        [BsonIgnore] public Avatar.AvatarManager? Avatars; // Loaded by DatabaseManager
        [BsonIgnore] public BattlePassManager BattlePassManager; // Loaded by DatabaseManager
        [BsonIgnore] public EnergyManager EnergyManager; // Loaded by DatabaseManager
        [BsonIgnore] public ExpManager ExpManager; // Loaded by DatabaseManager
        [BsonIgnore] public ClientGadgetEntityManager GadgetManager; // Loaded by DatabaseManager
        [BsonIgnore] public Inventory.InventoryManager Inventory; // Loaded by DatabaseManager
        [BsonIgnore] public Social.SocialManager SocialManager; // Loaded by DatabaseManager
        [BsonIgnore] public TeamManager TeamManager; // Loaded by DatabaseManager


        public Player(string heroName, string accountUid, int gameUid)
        {
            Profile = new(heroName);

            AccountUid = accountUid;
            BattlePassManager = new(this);
            EnergyManager = new(this);
            ExpManager = new(this);
            GadgetManager = new(this);
            GameUid = gameUid;
            PropManager = new(this);
            ResinManager = new(this);
            SocialManager = new(this);
        }

        private async Task OnCreate()
        {
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_PLAYER_LEVEL, 1, false);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_IS_SPRING_AUTO_USE, 1, false);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_SPRING_AUTO_USE_PERCENT, 50, false);
            await ResinManager.AddResinAsync(160);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_IS_FLYABLE, 0, false);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_MAX_STAMINA, 10000, false);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_CUR_PERSIST_STAMINA, 10000, false);
            SceneId = 3;
            RegionId = 1;

            // Pick character
            Session.State = SessionState.PICKING_CHARACTER;
            await Session.SendPacketAsync(new BasePacket(OpCode.DoSetPlayerBornDataNotify));
        }
        public ulong GetNextGameGuid()
        {
            ulong nextId = ++NextGuid;
            return ((ulong)GameUid << 32) + nextId;
        }

        public string GetNickName()
        {
            return Profile.Nickname;
        }
        public async Task SetSceneAsync(Scene? scene)
        {
            Scene = scene;
            if (scene == null) SceneId = 0;
            else SceneId = scene.SceneData.id;
        }

        public async Task OnLoginAsync()
        {
            // Create world
            World.World world = new(this);


            // Show opening cutscene if player has no avatars
            if (Avatars.GetAvatarCount() == 0)
            {
                await OnCreate();
                await world.AddPlayerAsync(this, EnterReason.Login, EnterType.Self, true);
            }
            else
                await world.AddPlayerAsync(this, EnterReason.Login);

            //await SendPacketAsync(new PacketPlayerDataNotify(this));

            // Multiplayer setting
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_PLAYER_MP_SETTING_TYPE, (int)MpSettingType.EnterAfterApply, false);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_IS_MP_MODE_AVAILABLE, 1, false);

            await ResinManager.OnLoginAsync();
        }

        // Called by DatabaseManager
        public async Task OnLoadAsync()
        {
            PropManager = new(this);
            ResinManager = new(this);
            ExpManager = new(this);
            BattlePassManager = new(this);
            GadgetManager = new(this);
            EnergyManager = new(this);
        }
        public bool IsInMultiplayer() { return World != null && World.IsMultiplayer; }

        //TODO
        public void SetPaused(bool newPauseState)
        {
            bool oldPauseState = Paused;
            Paused = newPauseState;

            if (newPauseState && !oldPauseState)
            {
                //StaminaManager.StopSustainedStaminaHandler();
            }
            else if (oldPauseState && !newPauseState)
            {
                //StaminaManager.StartSustainedStaminaHandler();
            }
        }

        public OnlinePlayerInfo GetOnlinePlayerInfo()
        {
            OnlinePlayerInfo onlineInfo = new()
            {
                Uid = (uint)GameUid,
                Nickname = Profile.Nickname,
                PlayerLevel = (uint)PlayerProperties[PlayerProperty.PROP_PLAYER_LEVEL],
                MpSettingType = (MpSettingType)PlayerProperties[PlayerProperty.PROP_PLAYER_MP_SETTING_TYPE],
                NameCardId = (uint)Profile.NameCardId,
                Signature = Profile.Signature,
                ProfilePicture = Profile.HeadImage,
                AvatarId = (uint)TeamManager.Teams[TeamManager.CurrentTeamIndex].AvatarInfo[TeamManager.CurrentCharacterIndex].AvatarId, // current selected avatar
                OnlineId = AccountUid, // not sure if correct
                //PsnId = 42069,
                WorldLevel = (uint)Profile.WorldLevel
            };

            if (World != null)
            {
                onlineInfo.CurPlayerNumInWorld = (uint)World.Players.Count;
            }
            if (Profile.BlacklistUidList != null)
                onlineInfo.BlacklistUidList.AddRange(Profile.BlacklistUidList);

            return onlineInfo;
        }

        public async Task SendPacketAsync(BasePacket packet)
        {
            await Session.SendPacketAsync(packet);
        }

    }
}
