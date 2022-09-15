using Microsoft.AspNetCore.Http;
using Weedwacker.WebServer.Authentication;

namespace Weedwacker.WebServer.Handlers
{
    internal class AuthenticationChangePassword : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await WebServer.AuthenticationSystem.GetExternalAuthenticator()
                .HandlePasswordReset(IAuthenticationSystem.FromExternalRequest(context));
            return true;
        }
    }
}
