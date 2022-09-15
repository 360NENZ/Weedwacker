using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class AuthenticationType : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsync(WebServer.AuthenticationSystem.GetType().Name);
            return true;
        }
    }
}
