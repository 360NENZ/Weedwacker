using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Database
{
    internal static class DatabaseManager
    {
        static MongoClient DbClient;
        static IMongoDatabase Database;
        static IMongoCollection<Player> Players;
        static IMongoCollection<AvatarManager> Avatars;
        static IMongoCollection<InventoryManager> Inventories;
        static IMongoCollection<TeamManager> Teams;
        static DatabaseProperties Properties;

        public static async Task Initialize()
        {
            
            BsonSerializer.RegisterSerializer(new EnumSerializer<PlayerProperty>(BsonType.String));
            BsonSerializer.RegisterSerializer(new EnumSerializer<FightProperty>(BsonType.String));
            BsonSerializer.RegisterSerializer(new EnumSerializer<ItemType>(BsonType.String));

            DbClient = new MongoClient(GameServer.Configuration.Database.ConnectionUri);
            // Databases and collections are implicitly created
            Database = DbClient.GetDatabase(GameServer.Configuration.Database.Database);
            Players = Database.GetCollection<Player>("players");
            Avatars = Database.GetCollection<AvatarManager>("avatars");
            Inventories = Database.GetCollection<InventoryManager>("inventories");
            Teams = Database.GetCollection<TeamManager>("teams");

            if (Database.GetCollection<DatabaseProperties>("dbProperties").Find(w => true).FirstOrDefault() == null)
            {
                Properties = new();
                Database.GetCollection<DatabaseProperties>("dbProperties").InsertOne(Properties);
            }
            else
            {
                Properties = Database.GetCollection<DatabaseProperties>("dbProperties").Find(w => true).First();
            }

            Logger.WriteLine("Connected to GameServer database");
        }

        public static async Task<Player?> CreatePlayerFromAccountUidAsync(string accountUid, string heroName = "", int gameUid = 0)
        {
            //Make sure there are no name or id collisions
            var queryResult = await Players.FindAsync(w => w.Profile.HeroName == heroName || w.AccountUid == accountUid || w.GameUid == gameUid);
            if (queryResult.ToList().Count > 0)
            {
                return null;
            }

            // Account

            if (gameUid == Properties.NextGameUid || gameUid == 0)
            {
                //Increment the counter
                var filter = Builders<DatabaseProperties>.Filter.Eq(x => x.NextGameUid, Properties.NextGameUid); // All the documents with (NextUid = Properties.NextUid)
                var update = Builders<DatabaseProperties>.Update.Inc(x => x.NextGameUid, 1); // Increment counter by 1
                gameUid = Properties.NextGameUid++;
                await Database.GetCollection<DatabaseProperties>("dbProperties").UpdateOneAsync(filter, update);
            }
            Player player = new(heroName, accountUid, gameUid);
            await Players.InsertOneAsync(player);
            return player;
        }

        public static async Task SavePlayerAsync(Player player)
        {
            // Replaces the player document.
            await Players.ReplaceOneAsync<Player>(w => w.AccountUid == player.AccountUid, player);
        }

        public static async Task UpdatePlayerAsync(FilterDefinition<Player> filter, UpdateDefinition<Player> update)
        {
            await Players.UpdateOneAsync(filter, update);
        }

        public static async Task<Player?> GetPlayerByAccountUidAsync(string uid)
        {
            var matches = await Players.FindAsync(w => w.AccountUid == uid);
            var player = await matches.FirstOrDefaultAsync() ?? await CreatePlayerFromAccountUidAsync(uid);
            //Attach player systems to the player
            player.Avatars = await GetAvatarsByPlayerAsync(player) ?? new AvatarManager(player); // Load avatars before inventory, so that we can attach weapons while loading them
            player.Inventory = await GetInventoryByPlayerAsync(player) ?? new InventoryManager(player);
            player.TeamManager = await GetTeamsByPlayerAsync(player) ?? new TeamManager(player);
            await player.OnLoadAsync();

            return player;
        }

        public static async Task<AvatarManager?> CreateAvatarStorageAsync(AvatarManager avatars)
        {
            await Avatars.InsertOneAsync(avatars);
            return avatars;
        }
        public static async Task SaveAvatarsAsync(AvatarManager avatars)
        {
            await Avatars.ReplaceOneAsync<AvatarManager>(w => w.OwnerId == avatars.OwnerId, avatars);
        }

        public static async Task<UpdateResult> UpdateAvatarsAsync(FilterDefinition<AvatarManager> filter, UpdateDefinition<AvatarManager> update)
        {
            return await Avatars.UpdateOneAsync(filter, update);
        }

        private static async Task<AvatarManager?> GetAvatarsByPlayerAsync(Player owner)
        {
            AvatarManager avatars = await Database.GetCollection<AvatarManager>("avatars").Find(w => w.OwnerId == owner.GameUid).FirstOrDefaultAsync();
            if (avatars != null) await avatars.OnLoadAsync(owner);
            return avatars;
        }
        private static async Task<InventoryManager?> GetInventoryByPlayerAsync(Player owner)
        {
            InventoryManager inventory = await Database.GetCollection<InventoryManager>("inventories").Find(w => w.OwnerId == owner.GameUid).FirstOrDefaultAsync();
            if (inventory != null) await inventory.OnLoadAsync(owner);
            return inventory;
        }
        public static async Task<InventoryManager?> CreateInventoryAsync(InventoryManager inventory)
        {
            await Inventories.InsertOneAsync(inventory);
            return inventory;
        }

        public static async Task<UpdateResult> UpdateInventoryAsync(FilterDefinition<InventoryManager> filter, UpdateDefinition<InventoryManager> update)
        {
            return await Inventories.UpdateOneAsync(filter, update);
        }

        public static async Task<TeamManager?> CreateTeamStorageAsync(TeamManager teams)
        {
            await Teams.InsertOneAsync(teams);
            return teams;
        }
        public static async Task SaveTeamsAsync(TeamManager teams)
        {
            await Teams.ReplaceOneAsync<TeamManager>(w => w.OwnerId == teams.OwnerId, teams);
        }

        public static async Task<UpdateResult> UpdateTeamsAsync(FilterDefinition<TeamManager> filter, UpdateDefinition<TeamManager> update)
        {
            return await Teams.UpdateOneAsync(filter, update);
        }

        private static async Task<TeamManager?> GetTeamsByPlayerAsync(Player owner)
        {
            TeamManager teams = await Database.GetCollection<TeamManager>("teams").Find(w => w.OwnerId == owner.GameUid).FirstOrDefaultAsync();
            if (teams != null) await teams.OnLoadAsync(owner);
            return teams;
        }
    }
}
