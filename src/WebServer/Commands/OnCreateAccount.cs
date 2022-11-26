using Weedwacker.WebServer.Database;

namespace Weedwacker.WebServer.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task<string> OnCreateAccount(params string[] args) // username
        {
            Account? account = await DatabaseManager.GetAccountByNameAsync(args[0]);
            if (account != null)
            {
                return $"Username {args[0]} already exists!";
            }
            else
            {
                DatabaseManager.CreateAccountWithUid(args[0]);
                return $"successfully created account {args[0]}";
            }
        }
    }
}
