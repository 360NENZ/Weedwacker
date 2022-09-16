using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class PreCache : IHandler
    {
        // Known Queries: biz=hk4e_global&client=3
        public class PreCacheResJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; } = new();
            public class Data
            {
                public Vals vals { get; set; } = new();
                public class Vals
                {
                    public bool enable { get; set; } = true;
                    public string url { get; set; } = "https://sdk.hoyoverse.com/sw.html";
                }
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new PreCacheResJson());
            return true;
        }
    }
}
