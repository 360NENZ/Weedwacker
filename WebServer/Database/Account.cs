namespace Weedwacker.WebServer.Database
{
    public class Account
    {
        /*@Id*/ public uint Id { get; set; }
        /*@Indexed(options = @IndexOptions(unique = true))
        @Collation(locale = "simple", caseLevel = true)
        */private string username;
        private string password; // Unused for now

        private int reservedPlayerId;
        private string email;

        private string token;
        private string sessionKey; // Session token for dispatch server
        private List<string> permissions;
        private System.Globalization.CultureInfo locale;

        private string banReason;
        private int banEndTime;
        private int banStartTime;
        private bool isBanned;
    }
}
