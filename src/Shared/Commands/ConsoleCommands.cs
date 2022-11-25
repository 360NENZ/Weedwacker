namespace Weedwacker.Shared.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task<string> OnHelp(params string[] args)
        {
            await Task.Yield();
            return "Help command used";
        }

        public static async Task<string> OnHashAbility(params string[] args)
        {
            await Task.Yield();
            return Utils.Utils.AbilityHash(args[0]).ToString();
        }

        public static async Task<string> OnHashPath(params string[] args)
        {
            await Task.Yield();
            return Utils.Utils.GetPathHash(args[0].ToString()).ToString();
        }
    }
}
