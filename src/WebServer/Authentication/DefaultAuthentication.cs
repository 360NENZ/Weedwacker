using Weedwacker.WebServer.Authentication.Objects;
using Weedwacker.Shared.Utils;
using Weedwacker.Shared.Authentication;
using Weedwacker.WebServer.Database;

namespace Weedwacker.WebServer.Authentication
{
    /// <summary>
    /// The default authentication implementation.
    /// Allows all users to access any account.
    /// </summary>
    public class DefaultAuthentication : IAuthenticationSystem
    {
        private IAuthenticator<LoginResultJson> PasswordAuthenticator = new PasswordAuthenticator();
        private IAuthenticator<LoginResultJson> GameTokenAuthenticator = new GameTokenAuthenticator();
        private IAuthenticator<LoginResultJson> TokenAuthenticator = new TokenAuthenticator();
        private IAuthenticator<ComboTokenResJson> SessionKeyAuthenticator = new SessionKeyAuthenticator();
        private IExternalAuthenticator ExternalAuthenticator = new ExternalAuthentication();
        private IOAuthAuthenticator OAuthAuthenticator = new OAuthAuthentication();

        public void CreateAccount(string username, string password)
        {
            // Unhandled. The default authenticator doesn't store passwords.
        }

        public void ResetPassword(string username)
        {
            // Unhandled. The default authenticator doesn't store passwords.
        }

        public Account VerifyUser(string details)
        {
            Logger.WriteLine("Unable to Verify");
            return null;
        }

        public IAuthenticator<LoginResultJson> GetPasswordAuthenticator()
        {
            return PasswordAuthenticator;
        }
        public IAuthenticator<LoginResultJson> GetGameTokenAuthenticator()
        {
            return GameTokenAuthenticator;
        }
        public IAuthenticator<LoginResultJson> GetTokenAuthenticator()
        {
            return TokenAuthenticator;
        }

        public IAuthenticator<ComboTokenResJson> GetSessionKeyAuthenticator()
        {
            return SessionKeyAuthenticator;
        }

        public IExternalAuthenticator GetExternalAuthenticator()
        {
            return ExternalAuthenticator;
        }

        public IOAuthAuthenticator GetOAuthAuthenticator()
        {
            return OAuthAuthenticator;
        }


    }
}
