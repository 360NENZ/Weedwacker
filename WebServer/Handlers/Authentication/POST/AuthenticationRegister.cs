using Microsoft.AspNetCore.Http;
using Weedwacker.WebServer.Authentication;

namespace Weedwacker.WebServer.Handlers
{
    internal class AuthenticationRegister : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await WebServer.AuthenticationSystem.GetExternalAuthenticator()
                .HandleAccountCreation(IAuthenticationSystem.FromExternalRequest(context));
            return true;
        }
    }
}
