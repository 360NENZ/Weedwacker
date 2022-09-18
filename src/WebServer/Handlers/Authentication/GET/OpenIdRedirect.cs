using Microsoft.AspNetCore.Http;
using Weedwacker.WebServer.Authentication;

namespace Weedwacker.WebServer.Handlers
{
    internal class OpenIdRedirect : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await WebServer.AuthenticationSystem.GetOAuthAuthenticator()
                .HandleTokenProcess(IAuthenticationSystem.FromExternalRequest(context));
            return true;
        }
    }
}