namespace Weedwacker.WebServer.Authentication.Objects
{
    public class ComboTokenReqJson
    {
        public int app_id;
        public int channel_id;
        public string data;
        public string device;
        public string sign;

        public class LoginTokenData
        {
            public string uid;
            public string token;
            public bool guest;
        }
    }
}
