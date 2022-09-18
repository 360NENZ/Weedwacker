using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class OpPublic : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            context.Response.StatusCode = 404;
            await context.Response.WriteAsync("404 page not found");
            return true;
        }
    }
}
