using MongoDB.Driver;
using Weedwacker.Shared.Utils.Configuration;

namespace Weedwacker.WebServer.Database
{
    internal class DatabaseManager
    {
        MongoClient DbClient = new MongoClient(Config.WebConfig.database.server.connectionUri);
    }
}
