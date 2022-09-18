using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Weedwacker.Shared.Utils;
using Weedwacker.WebServer.Authentication;
using Weedwacker.WebServer.Authentication.Objects;

namespace Weedwacker.WebServer.Handlers
{
    internal class TokenLogin : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            // Parse body data.
            var bodyData = await context.Request.ReadFromJsonAsync<LoginTokenRequestJson>();
            // Validate body data.
            if (bodyData == null)
                return false;

            // Pass data to authentication handler.
            var responseData = await WebServer.AuthenticationSystem
                .GetTokenAuthenticator()
                .Authenticate(IAuthenticationSystem.FromTokenRequest(context, bodyData));
            // Send response.
            await context.Response.WriteAsJsonAsync(responseData);

            // Log to console.
            Logger.WriteLine(string.Format("Client {0} is trying to log in.", context.Connection.RemoteIpAddress.ToString()));
            return true;
        }
    }
}
