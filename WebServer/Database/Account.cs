using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Weedwacker.Shared.Utils;

namespace Weedwacker.WebServer.Database
{
    public class Account
    {
        [BsonId]
        [BsonElement("id")]
        [JsonIgnore]
        public uint IdNum { get; } // WebServer unique Id. Number, but sent as a string...
        [BsonIgnore]
        public string Id { get; private set; } // Too lazy to write custom json converter

        /*@Indexed(options = @IndexOptions(unique = true))
        @Collation(locale = "simple", caseLevel = true)
        */
        public string Username { get; private set; }
        private string Password; // Unused for now

        private int ReservedPlayerId;
        public string Email { get; private set; }

        public string Token { get; private set; }
        public string SessionKey { get; private set; } // Session token for dispatch server
        private List<string> Permissions;
        private System.Globalization.CultureInfo Locale;

        private string BanReason;
        private int BanEndTime;
        private int BanStartTime;
        private bool IsBanned;

        public Account() { }

        public Account(string username, uint id)
        {
            Username = username;
            IdNum = id;
            Id = id.ToString();
        }
        public void save()
        {
            DatabaseManager.SaveAccount(this);
        }

        public string generateSessionKey()
        {
            SessionKey = BitConverter.ToString(Crypto.CreateSessionKey(32)).Replace("-", string.Empty);
            save();
            return SessionKey;
        }

        public string generateLoginToken()
        {
            Token = BitConverter.ToString(Crypto.CreateSessionKey(32)).Replace("-", string.Empty);
            save();
            return Token;
        }
    }
}
