using Weedwacker.GameServer;
using Weedwacker.Shared.Utils;

await GameServer.Start();

string? command = "";
while (command != "stop")
{
    command = Console.ReadLine(); // wait here (later make this be console command handler)
    if(command == "test")
    {
        foreach (var entry in GameServer.AvatarInfo)
        {
            Logger.DebugWriteLine(entry.Value.AvatarId.ToString());
        }
    }
}