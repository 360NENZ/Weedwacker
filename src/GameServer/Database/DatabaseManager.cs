using MongoDB.Driver;
using Weedwacker.Shared.Utils;
using Weedwacker.Shared.Utils.Configuration;

namespace Weedwacker.GameServer.Database
{
    internal class DatabaseManager
    {
        static MongoClient DbClient;
        static IMongoDatabase Database;
        static IMongoCollection<Player> Players;
        static DatabaseProperties Properties;
        public static void Initialize()
        {
            DbClient = new MongoClient(GameServer.Configuration.Database.ConnectionUri);
            // Databases and collections are implicitly created
            Database = DbClient.GetDatabase(GameServer.Configuration.Database.Database);
            Players = Database.GetCollection<Player>("players");

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
            var queryResult = Players.Find(w => w.HeroName == heroName || w.AccountUid == accountUid || w.GameUid == gameUid);
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
            Players.InsertOne(player);
            return player;
        }

        public static async Task SavePlayerAsync(Player player)
        {
            // Replaces the player document.
            await Players.ReplaceOneAsync<Player>(w => w.AccountUid == player.AccountUid, player);
        }

        public static void UpdatePlayer(string field, params string[] args)
        {

        }

        public static async Task<Player?> GetPlayerByGameUidAsync(int uid)
        {
            var matches = await Players.FindAsync(w => w.GameUid == uid);
            return matches.FirstOrDefault();
        }

        public static async Task<Player?> GetPlayerByAccountUidAsync(string uid)
        {
            var matches = await Players.FindAsync(w => w.AccountUid == uid);
            return matches.FirstOrDefault() ?? await CreatePlayerFromAccountUidAsync(uid);
        }

        public static async Task<Player?> GetPlayerByNameAsync(string name)
        {
            var matches = await Players.FindAsync(w => w.HeroName == name);
            return matches.FirstOrDefault();
        }
    }
}
