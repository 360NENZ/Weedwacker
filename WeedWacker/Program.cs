using Weedwacker;
using Weedwacker.Commands;
using Weedwacker.Server;
using Weedwacker.Server.HTTP;


namespace Weedwacker
{
    static class Weedwacker
    {
        public static Config.ConfigContainer configContainer;

        static async Task Main()
        {
            configContainer = await Config.Load();
            RegionManager.Initialize();
            WebServer.Start();
            // Always start this last

            await ConsoleHandler.Start();
        }
    }
}