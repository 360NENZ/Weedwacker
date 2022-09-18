using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class LoadConfig : IHandler
    {
        // Known Queries: client=3&game_key=hk4e_global
        public class LoadConfigRspJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; } = new();
            public class Data
            {
                public int id { get; set; } = 6;
                public string game_key { get; set; } = "hk4e_global";
                public string client { get; set; } = "PC";
                public string identity { get; set; } = "I_IDENTITY";
                public bool guest { get; set; } = false;
                public string ignore_versions { get; set; } = "";
                public string scene { get; set; } = "S_NORMAL";
                public string name { get; set; } = "原神海外";
                public bool disable_regist { get; set; } = false;
                public bool enable_email_captcha { get; set; } = false;
                public string[] thirdparty { get; set; } = {"fb", "tw"};
                public bool disable_mmt { get; set; } = false;
                public bool server_guest { get; set; } = false;
                public ThirdPartyIgnore thirdparty_ignore { get; set; } = new();
                public bool enable_ps_bind_account { get; set; } = false;
                public ThirdPartyLoginConfigs thirdparty_login_configs { get; set; } = new(); 
                public class ThirdPartyIgnore
                {
                    public string tw { get; set; } = "";
                    public string fb { get; set; } = "";
                }
                public class ThirdPartyLoginConfigs
                {
                    public TW tw { get; set; } = new();
                    public FB fb { get; set; } = new();
                    public class TW
                    {
                        public string token_type { get; set; } = "TK_GAME_TOKEN";
                        public int game_token_expires_in { get; set; } = 2592000;
                    }
                    public class FB
                    {
                        public string token_type { get; set; } = "TK_GAME_TOKEN";
                        public int game_token_expires_in { get; set; } = 2592000;
                    }
                }

            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new LoadConfigRspJson());
            return true;
        }
    }
}
