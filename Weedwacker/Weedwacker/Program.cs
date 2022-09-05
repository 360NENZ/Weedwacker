using Weedwacker;
using Weedwacker.Commands;
using Weedwacker.Server.HTTP;
await Config.Load();
WebServer.Start();
await ConsoleHandler.Start(); // Always start this last