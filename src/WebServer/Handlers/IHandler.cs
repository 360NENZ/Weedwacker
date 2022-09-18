using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal interface IHandler
    {
        public Task<bool> HandleAsync(HttpContext context);
    }
}
