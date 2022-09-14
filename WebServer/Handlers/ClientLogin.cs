using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Weedwacker.Shared.Utils;
using Weedwacker.WebServer.Authentication;
using Weedwacker.WebServer.Authentication.Objects;

namespace Weedwacker.WebServer.Handlers;

internal class ClientLogin : IHandler
{ 
    public Task<bool> HandleAsync(HttpContext context)
    {
        // Parse body data.
        var bodyData = context.Request.ReadFromJsonAsync<LoginAccountRequestJson>().Result;

        // Validate body data.
        if (bodyData == null)
        {
            return Task.FromResult(false);
        }
        // Pass data to authentication handler.
        var responseData = WebServer.AuthenticationSystem
                .GetPasswordAuthenticator()
                .Authenticate(IAuthenticationSystem.FromPasswordRequest(context, bodyData));
        // Send response.
        context.Response.WriteAsJsonAsync(JsonConvert.SerializeObject(responseData));
        
        // Log to console.
        Logger.WriteLine(string.Format("Client {0} is trying to log in.", context.Connection.RemoteIpAddress.ToString()));
        return Task.FromResult(true);
    }
}
