using NLua;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Systems.Script.Scene
{
    internal class SceneScriptManager
    {
        public SceneInfo Info;
        public World.Scene Scene;
        public ScriptMonsterSpawnService ScriptMonsterSpawnService;

        public static Task<SceneScriptManager> CreateAsync(int sceneId, string scriptPath)
        {          
            var scene = new SceneScriptManager();
            return scene.InitializeAsync(sceneId, scriptPath);
        }

        private async Task<SceneScriptManager> InitializeAsync(int sceneId, string scriptPath)
        {
            return this;
        }
        internal Task CallEvent(EventType eventType, ScriptArgs scriptArgs)
        {
            throw new NotImplementedException();
        }
    }
}
