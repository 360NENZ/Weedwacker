using Microsoft.AspNetCore.Http;
using Weedwacker.Shared.Authentication;

namespace Weedwacker.WebServer.Authentication.Objects
{
    ///<summary>
    ///A data container that holds relevant data for authenticating a client.
    ///</summary>
    public class AuthenticationRequest
    {

        public readonly HttpContext? Context;
        public readonly LoginAccountRequestJson? PasswordRequest;
        public readonly VerifyTokenRequestJson? TokenRequest;
        public readonly ComboTokenReqJson? SessionKeyRequest;
        public readonly ComboTokenReqJson.LoginTokenData? SessionKeyData;

        public AuthenticationRequest(HttpContext context, ComboTokenReqJson sessionKeyRequest, ComboTokenReqJson.LoginTokenData sessionKeyData)
        {
            Context = context;
            SessionKeyRequest = sessionKeyRequest;
            SessionKeyData = sessionKeyData;
        }

        public AuthenticationRequest(HttpContext context, VerifyTokenRequestJson tokenRequest)
        {
            Context = context;
            TokenRequest = tokenRequest;
        }

        public AuthenticationRequest(HttpContext context, LoginAccountRequestJson passwordRequest)
        {
            Context = context;
            PasswordRequest = passwordRequest;
        }

        public AuthenticationRequest(HttpContext context)
        {
            Context = context;
        }
    }
}
