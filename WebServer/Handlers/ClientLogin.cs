using Ceen;
using Newtonsoft.Json;
using Weedwacker.Shared.Utils;
using Weedwacker.WebServer.Authentication;
using Weedwacker.WebServer.Authentication.Objects;

namespace Weedwacker.WebServer.Handlers;

internal class ClientLogin : IHttpModule
{
    public Task<bool> HandleAsync(IHttpContext context)
    {
        // Parse body data.
        string rawBodyData = context.Request.Body.ReadAllAsStringAsync().Result;
        var bodyData = JsonConvert.DeserializeObject<LoginAccountRequestJson>(rawBodyData);

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
        context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(responseData));
        
        // Log to console.
        Logger.WriteLine(string.Format("Client {0} is trying to log in.", context.GetRemoteIP()));
        return Task.FromResult(true);
    }
}
