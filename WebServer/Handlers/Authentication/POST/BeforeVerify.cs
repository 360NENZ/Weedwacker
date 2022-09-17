using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class BeforeVerify : IHandler
    {
        public class BeforeVerifyReqJson
        {
            public string app_id { get; set; }
            public string channel_id { get; set; }
            public string open_id { get; set; }
            public string combo_token { get; set; }
            public Role role { get; set; }
            public int time { get; set; }
            public class Role
            {
                public string region { get; set; }
                public string uid { get; set; }
            }

        }
        public class BeforeVerifyRspJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; } = new();
            public class Data
            {
                public bool is_heartbeat_required { get; set; } = false;
                public bool is_realname_required { get; set; } = false;
                public bool is_guardian_required { get; set; } = false;
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new BeforeVerifyRspJson());
            return true;
        }
    }
}
