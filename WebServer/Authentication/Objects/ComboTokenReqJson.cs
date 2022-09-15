namespace Weedwacker.WebServer.Authentication.Objects
{
    public class ComboTokenReqJson
    {
        public int app_id { get; set; }
        public int channel_id { get; set; }
        public string data { get; set; }
        public string device { get; set; }
        public string sign { get; set; }

        public class LoginTokenData
        {
            public string uid { get; set; }
            public string token { get; set; }
            public bool guest { get; set; }
        }
    }
}
