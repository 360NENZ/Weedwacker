using Weedwacker.WebServer.Commands;

namespace Weedwacker.WebServer
{
    static class Program
    {

        static void Main(string[] args)
        {
            WebServer.Start();

            // Always start this last
            await ConsoleHandler.Start();
        }
    }
}