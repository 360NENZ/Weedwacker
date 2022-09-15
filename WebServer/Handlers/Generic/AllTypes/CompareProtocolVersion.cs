using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class CompareProtocolVersion : IHandler
    {
        public class CompareProtocolVersionResJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; } = new();
            public class Data
            {
                public bool modified { get; set; } = true;
                public Protocol protocol { get; set; } = new();
                public class Protocol
                {
                    public int id { get; set; } = 0;
                    public int app_id { get; set; } = 4;
                    public string language { get; set; } = "en";
                    public string user_proto { get; set; } = "";
                    public string priv_proto { get; set; } = "";
                    public int major { get; set; } = 7;
                    public int minimum { get; set; } = 0;
                    public string create_time { get; set; } = "0";
                    public string teenager_proto { get; set; } = "";
                    public string third_proto { get; set; } = "";
                }
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new CompareProtocolVersionResJson());
            return true;
        }
    }
}
