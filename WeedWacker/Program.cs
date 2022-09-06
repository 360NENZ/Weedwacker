using Weedwacker;
using Weedwacker.Commands;
using Weedwacker.Server;
using Weedwacker.Server.HTTP;
await Config.Load();
RegionManager.Initialize();
WebServer.Start();
await ConsoleHandler.Start(); // Always start this last