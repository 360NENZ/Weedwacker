using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using Weedwacker.GameServer.Systems.Inventory;
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
        static IMongoCollection<GameItem> Items;
        static DatabaseProperties Properties;

        public static async Task Initialize()
        {
            DbClient = new MongoClient(GameServer.Configuration.Database.ConnectionUri);
            // Databases and collections are implicitly created
            Database = DbClient.GetDatabase(GameServer.Configuration.Database.Database);
            Players = Database.GetCollection<Player>("players");
            Avatars = Database.GetCollection<AvatarManager>("avatars");

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

        public static async Task<Player?> CreatePlayerFromAccountUidAsync( string accountUid, string heroName = "", int gameUid = 0)
        {
            //Make sure there are no name or id collisions
            var queryResult = await Players.FindAsync(w => w.HeroName == heroName || w.AccountUid == accountUid || w.GameUid == gameUid);
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

        public static async Task UpdatePlayerAsync(Tuple<string?,string> queryFilterAndUpdate)
        {

            string? filterString = queryFilterAndUpdate.Item1;
            var filter = filterString == null ? Builders<Player>.Filter.And(filterString) : Builders<Player>.Filter.Empty;

            string updateString = queryFilterAndUpdate.Item2;
            var pipeline = new EmptyPipelineDefinition<Player>().AppendStage<Player, Player, Player>(updateString);
            var update = Builders<Player>.Update.Pipeline(pipeline);

            await Players.UpdateOneAsync(filter, update);
        }
        public static async Task<Player?> GetPlayerByAccountUidAsync(string uid)
        {
            var matches = await Players.FindAsync(w => w.AccountUid == uid);
            var player = await matches.FirstOrDefaultAsync() ?? await CreatePlayerFromAccountUidAsync(uid);
            //Attach player systems to the player
            player.Avatars = await GetAvatarsByPlayerAsync(player) ?? new AvatarManager(player);

            return player;
        }

        public static async Task<AvatarManager?> CreateAvatarStorageAsync(Player player)
        {
            //Make sure there are no id collisions
            var queryResult = await Avatars.FindAsync(w => w.OwnerId == player.GameUid);
            if (queryResult.ToList().Count > 0)
            {
                return null;
            }
            AvatarManager avatars = new(player);
            await Avatars.InsertOneAsync(avatars);
            return avatars;
        }
        public static async Task SaveAvatarsAsync(AvatarManager avatars)
        {
            await Avatars.ReplaceOneAsync<AvatarManager>(w => w.OwnerId == avatars.OwnerId, avatars);
        }

        public static async Task<UpdateResult> UpdateAvatarsAsync(Tuple<string?, string> queryFilterAndUpdate)
        {

            string? filterString = queryFilterAndUpdate.Item1;
            var filter = filterString == null ? Builders<AvatarManager>.Filter.And(filterString) : Builders<AvatarManager>.Filter.Empty;

            string updateString = queryFilterAndUpdate.Item2;
            var pipeline = new EmptyPipelineDefinition<AvatarManager>().AppendStage<AvatarManager, AvatarManager, AvatarManager>(updateString);
            var update = Builders<AvatarManager>.Update.Pipeline(pipeline);

            return await Avatars.UpdateOneAsync(filter, update);
        }



        private static async Task<AvatarManager?> GetAvatarsByPlayerAsync(Player owner)
        {
            AvatarManager avatars = await Database.GetCollection<AvatarManager>("avatars").Find(w => w.OwnerId == owner.GameUid).FirstOrDefaultAsync();
            if (avatars != null) await avatars.OnLoadAsync(owner);
            return avatars;
        }
    }
}
