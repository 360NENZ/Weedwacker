using Weedwacker.Shared.Commands;
using Weedwacker.WebServer;

WebServer.Start();
ConsoleHandler.AddCommand("createaccount", 1, Weedwacker.Shared.Enums.UserRank.Console, Weedwacker.WebServer.Commands.ConsoleCommands.OnCreateAccount);
await ConsoleHandler.Start();