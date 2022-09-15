using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class Log : IHandler
    {
        public class LogResJson
        {
            public int code { get; set; } = 0;
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new LogResJson());
            return true;
        }
    }
}

