using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    // Known Queries: topic=plat_explog_sdk_v2
    internal class LogBatch : IHandler
    {
        public class LogBatchReqJson
        {
            public string data { get; set; }//ginormous
        }
        public class LogBatchResJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "success";
            public Data? data { get; set; } = null;
            public class Data
            {

            }
        }

        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new LogBatchResJson());
            return true;
        }
    }
}
