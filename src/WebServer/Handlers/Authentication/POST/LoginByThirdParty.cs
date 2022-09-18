using Microsoft.AspNetCore.Http;
using Weedwacker.WebServer.Authentication;

namespace Weedwacker.WebServer.Handlers
{
    internal class LoginByThirdParty : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await WebServer.AuthenticationSystem.GetOAuthAuthenticator()
                .HandleLogin(IAuthenticationSystem.FromExternalRequest(context));
            return true;
        }
    }
}
