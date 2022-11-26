using Microsoft.AspNetCore.Http;
using Weedwacker.Shared.Authentication;
using Weedwacker.Shared.Utils;
using Weedwacker.WebServer.Authentication;
using Weedwacker.WebServer.Authentication.Objects;

namespace Weedwacker.WebServer.Handlers;

internal class ClientLogin : IHandler
{
    // Known Queries: biz_key=hk4e_global&client_type=3 
    public async Task<bool> HandleAsync(HttpContext context)
    {
        // Parse body data.
        var bodyData = await context.Request.ReadFromJsonAsync<LoginAccountRequestJson>();

        // Validate body data.
        if (bodyData.account == null)
        {
            return false;
        }
        // Pass data to authentication handler.
        LoginResultJson responseData = await WebServer.AuthenticationSystem
                .GetPasswordAuthenticator()
                .Authenticate(IAuthenticationSystem.FromPasswordRequest(context, bodyData));
        // Send response.
        await context.Response.WriteAsJsonAsync(responseData);

        // Log to console.
        Logger.WriteLine(string.Format("Client {0} is trying to log in.", context.Connection.RemoteIpAddress.ToString()));
        return true;
    }
}
