using Weedwacker.GameServer.Systems.Script.Scene;
using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Systems.Script
{
    internal class ScriptMonsterSpawnService
    {
        private readonly SceneScriptManager SceneScriptManager;
        public readonly List<IScriptMonsterListener> OnMonsterCreatedListener = new();

        public readonly List<IScriptMonsterListener> OnMonsterDeadListener = new();

        public ScriptMonsterSpawnService(SceneScriptManager sceneScriptManager)
        {
            SceneScriptManager = sceneScriptManager;
        }

        public void OnMonsterDead(MonsterEntity entityMonster)
        {
            OnMonsterDeadListener.ForEach(l => l.OnNotify(entityMonster));
        }
    }
}
