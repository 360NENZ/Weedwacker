using Weedwacker;
using Weedwacker.WebServer.Commands;
using Weedwacker.WebServer;


namespace Weedwacker.WebServer
{
    static class Program
    {

        static async Task Main()
        {
            WebServer.Start();

            // Always start this last
            await ConsoleHandler.Start();
        }
    }
}