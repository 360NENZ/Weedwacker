using Microsoft.AspNetCore.Http;
using Weedwacker.WebServer.Authentication;

namespace Weedwacker.WebServer.Handlers
{
    internal class AuthenticationLogin : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await WebServer.AuthenticationSystem.GetExternalAuthenticator()
                .HandleLogin(IAuthenticationSystem.FromExternalRequest(context));
            return true;
        }
    }
}
