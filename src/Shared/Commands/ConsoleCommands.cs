namespace Weedwacker.Shared.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task<string> OnHelp(params string[] args)
        {
            await Task.Yield();
            return "Help command used";
        }
    }
}
