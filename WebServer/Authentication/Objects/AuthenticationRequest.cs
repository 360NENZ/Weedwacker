using Ceen;

namespace Weedwacker.WebServer.Authentication.Objects
{
    ///<summary>
    ///A data container that holds relevant data for authenticating a client.
    ///</summary>
    public class AuthenticationRequest
    {

        public readonly IHttpContext? Context;
        public readonly LoginAccountRequestJson? PasswordRequest;
        public readonly LoginTokenRequestJson? TokenRequest;
        public readonly ComboTokenReqJson? SessionKeyRequest;
        public readonly ComboTokenReqJson.LoginTokenData? SessionKeyData;

        public AuthenticationRequest(IHttpContext? context, ComboTokenReqJson? sessionKeyRequest, ComboTokenReqJson.LoginTokenData? sessionKeyData)
        {
            Context = context;
            SessionKeyRequest = sessionKeyRequest;
            SessionKeyData = sessionKeyData;
        }

        public AuthenticationRequest(IHttpContext? context, LoginTokenRequestJson? tokenRequest)
        {
            Context = context;
            TokenRequest = tokenRequest;
        }

        public AuthenticationRequest(IHttpContext? context, LoginAccountRequestJson? passwordRequest)
        {
            Context = context;
            PasswordRequest = passwordRequest;
        }

        public AuthenticationRequest(IHttpContext? context)
        {
            Context = context;
        }
    }
}
