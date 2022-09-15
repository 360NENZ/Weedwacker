using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class PerfConfigVerify : IHandler
    {
        public class PerfConfigVerifyResJson
        {
            public int code { get; set; } = 0;
        }

        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new PerfConfigVerifyResJson());
            return true;
        }
    }
}

