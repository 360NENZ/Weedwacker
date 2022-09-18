using Weedwacker.WebServer.Authentication.Objects;
using Weedwacker.Shared.Utils;
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
            return this.PasswordAuthenticator;
        }

        public IAuthenticator<LoginResultJson> GetTokenAuthenticator()
        {
            return this.TokenAuthenticator;
        }

        public IAuthenticator<ComboTokenResJson> GetSessionKeyAuthenticator()
        {
            return this.SessionKeyAuthenticator;
        }

        public IExternalAuthenticator GetExternalAuthenticator()
        {
            return this.ExternalAuthenticator;
        }

        public IOAuthAuthenticator GetOAuthAuthenticator()
        {
            return this.OAuthAuthenticator;
        }
    }
}
