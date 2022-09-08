using Weedwacker.WebServer.Authentication.Objects;

namespace Weedwacker.WebServer.Authentication
{
    public interface IAuthenticator<T>
    {
        ///<summary>
        ///Attempt to authenticate the client with the provided credentials.
        ///</summary>
        ///<param name="request">The authentication request wrapped in a <see cref="AuthenticationRequest"/> object.</param>
        ///<returns>The result of the login in an object.</returns>
        T Authenticate(AuthenticationRequest request);
    }
}
