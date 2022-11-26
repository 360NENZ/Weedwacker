using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Weedwacker.Shared.Utils;
using Weedwacker.WebServer.Authentication;
using Weedwacker.WebServer.Authentication.Objects;

namespace Weedwacker.WebServer.Handlers
{
    internal class SessionKeyLogin : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            // Parse body data.
            var bodyData = await context.Request.ReadFromJsonAsync<ComboTokenReqJson>();

            // Validate body data.
            if (bodyData == null || bodyData.data == null)
                return false;

            // Decode additional body data.
            var tokenData = JsonConvert.DeserializeObject<ComboTokenReqJson.LoginTokenData>(bodyData.data);

            // Pass data to authentication handler.
            var responseData = await WebServer.AuthenticationSystem
                .GetSessionKeyAuthenticator()
                .Authenticate(IAuthenticationSystem.FromComboTokenRequest(context, bodyData, tokenData));
            // Send response.
            await context.Response.WriteAsJsonAsync(responseData);

            // Log to console.
            Logger.WriteLine(string.Format("Client {0} is trying to log in.", context.Connection.RemoteIpAddress.ToString()));
            return true;
        }
    }
}
