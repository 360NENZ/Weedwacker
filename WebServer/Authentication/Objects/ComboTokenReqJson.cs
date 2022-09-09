namespace Weedwacker.WebServer.Authentication.Objects
{
    public class ComboTokenReqJson
    {
        public readonly int app_id;
        public readonly int channel_id;
        public readonly string data;
        public readonly string device;
        public readonly string sign;

        public class LoginTokenData
        {
            public readonly string uid;
            public readonly string token;
            public readonly bool guest;
        }
    }
}
