using MongoDB.Driver;
using Weedwacker.Shared.Utils;
using Weedwacker.Shared.Utils.Configuration;

namespace Weedwacker.WebServer.Database
{
    internal class DatabaseManager
    {
        static MongoClient DbClient;
        static IMongoDatabase Database;
        static IMongoCollection<Account> Accounts;
        static DatabaseProperties Properties;
        public static void Initialize()
        {
            DbClient = new MongoClient(WebServer.Configuration.database.connectionUri);
            // Databases and collections are implicitly created
            Database = DbClient.GetDatabase(WebServer.Configuration.database.database);
            Accounts = Database.GetCollection<Account>("accounts");

            if(Database.GetCollection<DatabaseProperties>("dbProperties").Find(w => true).FirstOrDefault() == null)
            {
                Properties = new();
                Database.GetCollection<DatabaseProperties>("dbProperties").InsertOne(Properties);
            }
            Logger.WriteLine("Connected to WebServer database");
        }
        
        public static Account? CreateAccountWithUid(string username, uint uid)
        {
            //Make sure there are no name or id collisions
            var queryResult = Accounts.Find(w => w.Username == username || w.IdNum == uid);
            if(queryResult.ToList().Count > 0)
            {
                return null;
            }

            // Account
            Account account = new Account(username,uid);
            if(uid == Properties.NextUid)
            {
                //Increment the counter
                var filter = Builders<DatabaseProperties>.Filter.Eq(x => x.NextUid, Properties.NextUid); // All the documents with NextUid = Properties.NextUid
                var update = Builders<DatabaseProperties>.Update.Inc(x => x.NextUid, 1); // Increment counter by 1
                Properties.NextUid++;
                Database.GetCollection<DatabaseProperties>("dbProperties").UpdateOne(filter, update);
            }

            SaveAccount(account);
            return account;
        }
        
        public static void SaveAccount(Account account)
        {
            // Replaces the account document. If it doesn't exist, creates a new one
            Accounts.ReplaceOneAsync<Account>(w => w.Id == account.Id, account, new ReplaceOptions { IsUpsert = true });
        }

        public static void UpdateAccount(string field, params string[] args)
        {

        }

        public static Account? GetAccountById(uint uid)
        {
                return Accounts.Find(w => w.IdNum == uid).FirstOrDefault();
        }

        public static Account? GetAccountByName(string name)
        {
                return Accounts.Find(w => w.Username == name).FirstOrDefault();
        }
    }
}
