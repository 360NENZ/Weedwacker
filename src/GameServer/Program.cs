using Weedwacker.GameServer;
using Weedwacker.Shared.Commands;

await GameServer.Start();
ConsoleHandler.AddCommand("addavatar", 2, Weedwacker.Shared.Enums.UserRank.Player, Weedwacker.GameServer.Commands.ConsoleCommands.OnAddAvatar);
ConsoleHandler.AddCommand("openstate", 2, Weedwacker.Shared.Enums.UserRank.Player, Weedwacker.GameServer.Commands.ConsoleCommands.OnOpenState);
await ConsoleHandler.Start();