using NLua;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Script;
using Weedwacker.GameServer.Systems.Script.Scene;

namespace Weedwacker.GameServer.Systems.World
{
    internal class SceneScriptManager
    {
        private Lua LuaState;
        public SceneInfo Info;
        public Dictionary<int, SceneBlock> Blocks;
        public Dictionary<int, SceneGroup> Groups;
        public ScriptMonsterSpawnService ScriptMonsterSpawnService;

        public static Task<SceneScriptManager> CreateAsync(int sceneId, string scriptPath)
        {          
            var scene = new SceneScriptManager();
            scene.LuaState = new();
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
