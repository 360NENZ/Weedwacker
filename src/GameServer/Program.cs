using Weedwacker.GameServer;
using Weedwacker.GameServer.Data;

await GameData.LoadAllResourcesAsync();
await GameServer.Start();
Console.ReadLine(); // wait here (later make this be console command handler)