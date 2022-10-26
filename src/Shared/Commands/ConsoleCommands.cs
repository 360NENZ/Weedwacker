using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weedwacker.Shared.Commands
{
    public static class ConsoleCommands
    {
        public static async Task<string> OnHelp(params string[] args)
        {
            await Task.Yield();
            return "Help command used";
        }
    }
}
