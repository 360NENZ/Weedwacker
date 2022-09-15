using Weedwacker.WebServer.Authentication.Objects;

namespace Weedwacker.WebServer.Authentication
{
    /// <summary>
    /// Handles authentication via OAuth routes.
    /// </summary>
    public interface IOAuthAuthenticator
    {
        /// <summary>
        /// Called when an OAuth login request is made.
        /// </summary>
        /// <param name="request">The authentication request.</param>
        Task HandleLogin(AuthenticationRequest request);

        /// <summary>
        /// Called when a client requests to redirect to login page.
        /// </summary>
        /// <param name="request">The authentication request.</param>
        Task HandleRedirection(AuthenticationRequest request, ClientType clientType);

        /// <summary>
        /// Called when an OAuth login requests callback.
        /// </summary>
        /// <param name="request">The authentication request.</param>
        Task HandleTokenProcess(AuthenticationRequest request);

        /// <summary>
        /// The type of the client.
        /// Used for handling redirection.
        /// </summary>
        enum ClientType
        {
            DESKTOP, MOBILE
        }
    }
}
