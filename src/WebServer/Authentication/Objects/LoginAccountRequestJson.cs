namespace Weedwacker.WebServer.Authentication.Objects
{
    public class LoginAccountRequestJson
    {
        public string account { get; set; }
        public string password { get; set; }
        public bool is_crypto { get; set; }
    }
}
