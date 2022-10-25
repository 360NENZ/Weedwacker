using NLua;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Systems.Script.Scene
{
    internal class SceneScriptManager
    {
        public SceneInfo Info;
        public World.Scene Scene;
        public Dictionary<uint, Dictionary<string, int>> GroupVariables { get; private set; } = new(); // <groupId, <key, value>>
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

        internal int GetGroupVariable(uint block, uint group, string key, int defaultVal = default)
        {
            if (GroupVariables.TryGetValue(group, out Dictionary<string, int> variables))
            {
                if (variables.TryGetValue(key, out int value))
                    return value;
                else
                {
                    variables.Add(key, defaultVal);
                    return defaultVal;
                }
            }
            else if(defaultVal != default)
            {
                GroupVariables.Add(group, new() { { key, defaultVal } });
                return defaultVal;
            }
            else
            {
                var value = Info.BlocksInfo[block].GroupsInfo[group].variables.Find(w => w.name == key).value;
                GroupVariables.Add(group, new() { { key, value } });
                return value;
            }
        }

        internal void SetGroupVariable(uint group, string key, int value)
        {
            if (GroupVariables.TryGetValue(group, out Dictionary<string, int> variables))
                if (variables.ContainsKey(key))
                    variables[key] = value;
                else
                    variables.Add(key, value);
            else
                GroupVariables.Add(group, new Dictionary<string, int>() { { key, value } });
        }

        internal int RefreshGroup(int groupId, int suite)
        {
            throw new NotImplementedException();
        }

        internal int RemoveGroupSuite(uint blockId, int groupId, int suite)
        {
            throw new NotImplementedException();
        }
    }
}
