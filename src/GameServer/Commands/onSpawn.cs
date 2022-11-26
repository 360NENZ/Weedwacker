using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task<string> OnSpawn(params string[] args) // GameUid, id
        {
            if (!int.TryParse(args[0], out int guid) ||
                !GameServer.OnlinePlayers.ContainsKey(guid))
            {
                return "Player isn't online or doesn't exist";
            }
            var scene = GameServer.OnlinePlayers[guid].Player.Scene;
            if (!int.TryParse(args[1], out int id))
            {
                return "entity id NAN";
            }
#if false
            if (args.Length >= 3 && !int.TryParse(args[2], out int posOffset))
            {
                return "posOffset NAN";
            }
            if (args.Length >= 4 && !int.TryParse(args[3], out int rotOffset))
            {
                return "rotOffset NAN";
            }
#endif
            if (GameData.MonsterDataMap.ContainsKey(id))
            {
                await scene.AddEntityAsync(await MonsterEntity.CreateAsync(scene, GameServer.OnlinePlayers[guid].Player, GameData.MonsterDataMap[id], 3));
            }
            else if (GameData.GadgetDataMap.ContainsKey(id))
            {
                await scene.AddEntityAsync(new BaseGadgetEntity(scene, id));
            }
            else if (GameData.ItemDataMap.ContainsKey(id))
            {
                await scene.AddEntityAsync(new ItemEntity(scene, GameServer.OnlinePlayers[guid].Player, GameData.ItemDataMap[id], GameServer.OnlinePlayers[guid].Player.Position, 1));
            }
            else
                goto ERROR;

            return $"spawn entity {id} for player {guid}";
        ERROR:
            return $"could not find entity {id}";
        }
    }
}
