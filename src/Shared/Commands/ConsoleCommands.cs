namespace Weedwacker.Shared.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task<string> OnHelp(params string[] args)
        {
            await Task.Yield();
            return "Help command used";
        }

        public static async Task<string> OnHash(params string[] args)
        {
            await Task.Yield();
            return Utils.Utils.AbilityHash(args[0]).ToString();
        }
    }
}
