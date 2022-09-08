using Weedwacker.WebServer.Authentication.Objects;

namespace Weedwacker.WebServer.Authentication
{
    ///<summary>
    ///Handles authentication via external routes.
    ///</summary>
    public interface IExternalAuthenticator
    {
        ///<summary>
        ///Called when an external login request is made.
        ///</summary>
        ///<param name="request">The authentication request.</param>
        void HandleLogin(AuthenticationRequest request);

        ///<summary>
        ///Called when an external account creation request is made.
        ///For developers: Use AuthenticationRequest#getRequest() to get the request body.
        ///                Use AuthenticationRequest#getResponse() to get the response body.
        ///</summary>
        ///<param name="request">The authentication request.</param>
        void HandleAccountCreation(AuthenticationRequest request);

        ///<summary>
        ///Called when an external password reset request is made.
        ///For developers: Use AuthenticationRequest#getRequest() to get the request body.
        ///                Use AuthenticationRequest#getResponse() to get the response body.
        ///</summary>
        ///<param name="request">The authentication request.</param>
        void HandlePasswordReset(AuthenticationRequest request);
    }
}
