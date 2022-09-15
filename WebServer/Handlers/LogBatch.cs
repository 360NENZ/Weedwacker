using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class LogBatch : IHandler
    {
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
