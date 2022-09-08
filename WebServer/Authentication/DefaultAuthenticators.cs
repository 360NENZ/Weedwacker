using Weedwacker.WebServer.Authentication.Objects;
using Weedwacker.WebServer.Database;
using Weedwacker.Shared.Utils;
using Weedwacker.Shared.Utils.Configuration;
using Ceen;

namespace Weedwacker.WebServer.Authentication
{

    /// <summary>
    /// Handles the authentication request from the username and password form.
    /// </summary>
    public class PasswordAuthenticator : IAuthenticator<LoginResultJson>
    {
        public LoginResultJson Authenticate(AuthenticationRequest request)
        {
            var response = new LoginResultJson();

            var requestData = request.PasswordRequest;

            bool successfulLogin = false;
            string address = request.Context.GetRemoteIP();
            string responseMessage = "Username not found.";
            string loggerMessage = "";

            // Get account from database.
            Account account = DatabaseHelper.getAccountByName(requestData.account);
            if (Config.WebConfig.server.http.account.maxAccount <= -1)
            {
                // Check if account exists.
                if (account == null && Config.WebConfig.server.http.account.autoCreate)
                {
                    // This account has been created AUTOMATICALLY. There will be no permissions added.
                    account = DatabaseHelper.createAccountWithUid(requestData.account, 0);

                    // Check if the account was created successfully.
                    if (account == null)
                    {
                        responseMessage = "Username not found, create failed.";
                        Logger.WriteLine(string.Format("Client {0} failed to log in: Account create failed.", address));
                    }
                    else
                    {
                        // Continue with login.
                        successfulLogin = true;

                        // Log the creation.
                        Logger.WriteLine(string.Format("Client {0} succeessfully logged in: Account {} created.", address, response.data.account.uid));
                    }
                }
                else if (account != null)
                    successfulLogin = true;
                else
                    loggerMessage = string.Format("Client {0} failed to log in: Account not found.", address);
            }
            else
            {
                responseMessage = "Max account limit reached, create failed";
                loggerMessage = string.Format("Client {0} failed to log in: Max account limit reached", address);
            }

            // Set response data.
            if (successfulLogin)
            {
                response.message = "OK";
                response.data.account.uid = account.Id.ToString();
                response.data.account.token = account.generateSessionKey();
                response.data.account.email = account.getEmail();

                loggerMessage = string.Format("Client {0} logged in as {0}.", address, account.Id);
            }
            else
            {
                response.retcode = -201;
                response.message = responseMessage;

            }
            Logger.WriteLine(loggerMessage);

            return response;
        }
    }

    /// <summary>
    /// Handles the authentication request from the game when using a registry token.
    /// </summary>
    public class TokenAuthenticator : IAuthenticator<LoginResultJson>
    {
        public LoginResultJson Authenticate(AuthenticationRequest request)
        {
            var response = new LoginResultJson();

            var requestData = request.TokenRequest;

            bool successfulLogin;
            string address = request.Context.GetRemoteIP();
            string loggerMessage;

            // Log the attempt.
            Logger.WriteLine(string.Format("Client {0} is trying to log in via token.", address));

            if (Config.WebConfig.server.http.account.maxAccount <= -1)
            {

                // Get account from database.
                Account account = DatabaseHelper.getAccountById(requestData.uid);

                // Check if account exists/token is valid.
                successfulLogin = account != null && account.getSessionKey().equals(requestData.token);

                // Set response data.
                if (successfulLogin)
                {
                    response.message = "OK";
                    response.data.account.uid = account.Id.ToString();
                    response.data.account.token = account.getSessionKey();
                    response.data.account.email = account.getEmail();

                    // Log the login.
                    loggerMessage = string.Format("Client {0} logged in via token as {0}.", address, requestData.uid);
                }
                else
                {
                    response.retcode = -201;
                    response.message = "messages.dispatch.account.account_cache_error";

                    // Log the failure.
                    loggerMessage = string.Format("messages.dispatch.account.login_token_error", address);
                }

            }
            else
            {
                response.retcode = -201;
                response.message = "messages.dispatch.account.server_max_player_limit";

                loggerMessage = string.Format("messages.dispatch.account.login_max_player_limit", address);
            }

            Logger.WriteLine(loggerMessage);
            return response;
        }
    }

    /// <summary>
    /// Handles the authentication request from the game when using a combo token/session key.
    /// </summary>
    public class SessionKeyAuthenticator : IAuthenticator<ComboTokenResJson>
    {
        public ComboTokenResJson Authenticate(AuthenticationRequest request)
        {
            var response = new ComboTokenResJson();

            var requestData = request.SessionKeyRequest;
            var loginData = request.SessionKeyData;

            bool successfulLogin;
            string address = request.Context.GetRemoteIP();
            string loggerMessage;

            if (Config.WebConfig.account.maxPlayer <= -1)
            {
                // Get account from database.
                Account account = DatabaseHelper.getAccountById(loginData.uid);

                // Check if account exists/token is valid.
                successfulLogin = account != null && account.getSessionKey().equals(loginData.token);

                // Set response data.
                if (successfulLogin)
                {
                    response.message = "OK";
                    response.data.open_id = account.Id.ToString();
                    response.data.combo_id = "157795300";
                    response.data.combo_token = account.generateLoginToken();

                    // Log the login.
                    loggerMessage = string.Format("messages.dispatch.account.combo_token_success", address);

                }
                else
                {
                    response.retcode = -201;
                    response.message = "messages.dispatch.account.session_key_error";

                    // Log the failure.
                    loggerMessage = string.Format("messages.dispatch.account.combo_token_error", address);
                }
            }
            else
            {
                response.retcode = -201;
                response.message = "messages.dispatch.account.server_max_player_limit";

                loggerMessage = string.Format("messages.dispatch.account.login_max_player_limit", address);
            }

            Logger.WriteLine(loggerMessage);
            return response;
        }
    }

    /// <summary>
    /// Handles authentication requests from external sources.
    /// </summary>
    public class ExternalAuthentication : IExternalAuthenticator
    {
        public void HandleLogin(AuthenticationRequest request)
        {
            request.Context.result("Authentication is not available with the default authentication method.");
        }

        public void HandleAccountCreation(AuthenticationRequest request)
        {
            request.Context.result("Authentication is not available with the default authentication method.");
        }

        public void HandlePasswordReset(AuthenticationRequest request)
        {
            request.Context.result("Authentication is not available with the default authentication method.");
        }
    }

    /// <summary>
    /// Handles authentication requests from OAuth sources.Zenlith
    /// </summary>
    public class OAuthAuthentication : IOAuthAuthenticator
    {
        public void HandleLogin(AuthenticationRequest request)
        {
            request.Context.result("Authentication is not available with the default authentication method.");
        }

        public void HandleRedirection(AuthenticationRequest request, IOAuthAuthenticator.ClientType type)
        {
            request.Context.result("Authentication is not available with the default authentication method.");
        }

        public void HandleTokenProcess(AuthenticationRequest request)
        {
            request.Context.result("Authentication is not available with the default authentication method.");
        }
    }
}