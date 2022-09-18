using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    // Known Queries: game=hk4e_global&region=os_euro
    internal class KhulkGetGateAddress : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            context.Response.StatusCode = 404;
            await context.Response.WriteAsync("404 page not found");
            return true;
        }
    }
}
