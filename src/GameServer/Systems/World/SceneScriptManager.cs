using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Script;
using Weedwacker.GameServer.Systems.Script.Scene;

namespace Weedwacker.GameServer.Systems.World
{
    internal class SceneScriptManager
    {
        public readonly Scene Scene;
        public SceneInfo Info;
        public ScriptMonsterSpawnService ScriptMonsterSpawnService;

        public SceneScriptManager(Scene scene)
        {
            Scene = scene;
            //TODO
        }

        internal Task CallEvent(EventType eventType, ScriptArgs scriptArgs)
        {
            throw new NotImplementedException();
        }
    }
}
