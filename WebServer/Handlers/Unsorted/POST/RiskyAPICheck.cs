using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class RiskyAPICheck : IHandler
    {
        public class ApiCheckReqJson
        {
            public string action_type { get; set; } = "login";
            public string api_name { get; set; } = "/shield/api/login";
            public string username { get; set; }
        }
        public class ApiCheckResJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; } = new();
            public class Data
            {
                public string id { get; set; } = "none";
                public string action { get; set; } = "ACTION_NONE";//,ACTION_GEETEST
                public GeeTest? geetest { get; set; } = null;
                public class GeeTest
                {
                    public string challenge { get; set; }
                    public string gt { get; set; }
                    public int new_captcha { get; set; } = 1;
                    public int success { get; set; } = 1;
                }
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new ApiCheckResJson());
            return true;
        }
    }
}
