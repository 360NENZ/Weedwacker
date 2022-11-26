using System.Text.RegularExpressions;
using NLua;
using Vim.Math3d;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Script.Scene
{
    internal class SceneGroup
    {
        private Lua LuaState;
        private int SceneId;
        public readonly uint BlockId;

        public readonly uint group_id;
        public List<Monster>? monsters;
        public List<Npc>? npcs;
        public List<Gadget>? gadgets;
        public List<Region>? regions;
        public List<Trigger>? triggers;
        public List<Variable>? variables;
        public SortedList<uint, Suite> suites;
        public InitConfig init_config;

        public class Suite
        {
            private Lua LuaState;
            private LuaTable Table;
            public List<uint>? monsters; // config_id
            public List<uint>? npcs; // config_id
            public List<uint>? gadgets; // config_id
            public List<uint>? regions; // config_id
            public List<string>? triggers; // substring of trigger's name/action
            public uint rand_weight => (uint?)(long?)Table[$"{nameof(rand_weight)}"] ?? 0;
            public bool ban_refresh => (bool?)Table[$"{nameof(ban_refresh)}"] ?? false;

            public Suite(Lua luastate, LuaTable table)
            {
                LuaState = luastate;
                Table = table;
                if (Table[$"{nameof(monsters)}"] != null)
                    monsters = new List<uint>(LuaState.GetTableDict(Table[$"{nameof(monsters)}"] as LuaTable).Values.Select(w => (uint)(long)w));
                if (Table[$"{nameof(npcs)}"] != null)
                    npcs = new List<uint>(LuaState.GetTableDict(Table[$"{nameof(npcs)}"] as LuaTable).Values.Select(w => (uint)(long)w));
                if (Table[$"{nameof(gadgets)}"] != null)
                    gadgets = new List<uint>(LuaState.GetTableDict(Table[$"{nameof(gadgets)}"] as LuaTable).Values.Select(w => (uint)(long)w));
                if (Table[$"{nameof(regions)}"] != null)
                    regions = new List<uint>(LuaState.GetTableDict(Table[$"{nameof(regions)}"] as LuaTable).Values.Select(w => (uint)(long)w));
                if (Table[$"{nameof(monsters)}"] != null)
                    triggers = new List<string>(LuaState.GetTableDict(Table[$"{nameof(triggers)}"] as LuaTable).Values.Select(w => (string)w));
            }
        }

        public abstract class SpawnInfo
        {
            protected LuaTable Table;
            public uint config_id => (uint?)(long?)Table[$"{nameof(config_id)}"] ?? 0;
            public uint area_id => (uint?)(long?)Table[$"{nameof(area_id)}"] ?? 0;
            public Vector3 pos => new Vector3((float?)(double?)Table[$"{nameof(pos)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(pos)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(pos)}.z"] ?? 0);
            public Vector3 rot => new Vector3((float?)(double?)Table[$"{nameof(rot)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(rot)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(rot)}.z"] ?? 0);

            protected SpawnInfo(LuaTable table)
            {
                Table = table;
            }
        }

        public class Variable
        {
            private LuaTable Table;
            public uint configId => (uint?)(long?)Table[$"{nameof(configId)}"] ?? 0;
            public string name => (string?)Table[$"{nameof(name)}"] ?? "";
            public int value => (int?)(long?)Table[$"{nameof(value)}"] ?? 0;
            public bool no_refresh => (bool?)Table[$"{nameof(no_refresh)}"] ?? false;
            public Variable(LuaTable table)
            {
                Table = table;
            }
        }
        public class InitConfig
        {
            private LuaTable Table;
            public uint suite => (uint?)(long?)Table[$"{nameof(suite)}"] ?? 0;
            public uint end_suite => (uint?)(long?)Table[$"{nameof(end_suite)}"] ?? 0;
            public bool rand_suite => (bool?)Table[$"{nameof(rand_suite)}"] ?? false;

            public InitConfig(LuaTable table)
            {
                Table = table;
            }
        }
        public class Monster : SpawnInfo
        {
            public uint monster_id => (uint)(long)Table[$"{nameof(monster_id)}"];
            public uint level => (uint?)(long?)Table[$"{nameof(level)}"] ?? 0;
            public string? drop_tag => (string?)Table[$"{nameof(drop_tag)}"] ?? "";
            public uint pose_id => (uint?)(long?)Table[$"{nameof(pose_id)}"] ?? 0;


            public Monster(LuaTable table) : base(table)
            {
            }
        }

        public class Npc : SpawnInfo
        {
            public uint npc_id => (uint?)(long?)Table[$"{nameof(npc_id)}"] ?? 0;
            public uint room => (uint?)(long?)Table[$"{nameof(room)}"] ?? 0;

            public Npc(LuaTable table) : base(table)
            {
            }
        }

        public class Gadget : SpawnInfo
        {
            public uint gadget_id => (uint?)(long?)Table[$"{nameof(gadget_id)}"] ?? 0;
            public uint level => (uint?)(long?)Table[$"{nameof(level)}"] ?? 0;
            public string? drop_tag => (string?)Table[$"{nameof(drop_tag)}"] ?? "";
            public uint route_id => (uint?)(long?)Table[$"{nameof(route_id)}"] ?? 0;
            public bool showcutscene => (bool?)Table[$"{nameof(showcutscene)}"] ?? false;
            public bool isOneoff => (bool?)Table[$"{nameof(isOneoff)}"] ?? false;
            public bool persistent => (bool?)Table[$"{nameof(persistent)}"] ?? false;
            public Explore? explore;

            public Gadget(LuaTable table) : base(table)
            {
                if (Table[$"{nameof(explore)}"] != null)
                    explore = new(Table[$"{nameof(explore)}"] as LuaTable);
            }

            public class Explore
            {
                private LuaTable Table;
                public string name => (string?)Table[$"{nameof(name)}"] ?? "";
                public uint exp => (uint?)(long?)Table[$"{nameof(exp)}"] ?? 0;

                public Explore(LuaTable table)
                {
                    Table = table;
                }
            }
        }

        public class Region
        {
            private LuaTable Table;
            public uint config_id => (uint?)(long?)Table[$"{nameof(config_id)}"] ?? 0;
            public RegionShape shape => (RegionShape)(uint)(long)Table[$"{nameof(shape)}"];
            public uint radius => (uint?)(long?)Table[$"{nameof(radius)}"] ?? 0;
            public Vector3 pos => new Vector3((float?)(double?)Table[$"{nameof(pos)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(pos)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(pos)}.z"] ?? 0);
            public uint area_id => (uint?)(long?)Table[$"{nameof(area_id)}"] ?? 0;

            public Region(LuaTable luaTable)
            {
                Table = Table;
            }
        }

        public class Trigger
        {
            private LuaTable Table;
            public uint config_id => (uint?)(long?)Table[$"{nameof(config_id)}"] ?? 0;
            public string name => (string?)Table[$"{nameof(name)}"] ?? "";
            // It's "event" in the lua files, but event is a c# keyword ;_;
            public EventType _event => (EventType)(uint)(long)Table[$"event"];
            public string source => (string?)Table[$"{nameof(source)}"] ?? "";
            public string condition => (string?)Table[$"{nameof(condition)}"] ?? "";
            public string action => (string?)Table[$"{nameof(action)}"] ?? "";
            public uint trigger_count => (uint?)(long?)Table[$"{nameof(trigger_count)}"] ?? 0;
            public bool forbid_guest => (bool?)Table[$"{nameof(forbid_guest)}"] ?? false;

            public Trigger(LuaTable table)
            {
                Table = table;
            }
        }

        // for reference
        struct SeelieVariable1
        {
            public uint point_sum;
            public uint route_2;
            public uint gadget_seelie;
            public uint final_point;
        }

        internal static Task<SceneGroup?> CreateAsync(Lua luaState, int sceneId, uint blockId, uint id, FileInfo fileInfo)
        {
            SceneGroup group = new(luaState, sceneId, blockId, id);
            return group.InitializeAsync(fileInfo);
        }

        private SceneGroup(Lua luaState, int sceneId, uint blockId, uint groupId)
        {
            LuaState = luaState;
            SceneId = sceneId;
            BlockId = blockId;
            group_id = groupId;
        }

        private async Task<SceneGroup?> InitializeAsync(FileInfo groupInfo)
        {
            string script = groupInfo.FullName;

            script = Regex.Replace(script, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\
            LuaState.DoString($"_SCENE_GROUP{group_id} = {{EventType = _G.EventType; GadgetState = _G.GadgetState; RegionShape = _G.RegionShape; QuestState = _G.QuestState; EntityType = _G.EntityType; ScriptLib = _G.ScriptLib}}");
            LuaState.DoString(@$"_SCENE_GROUP{group_id}.require = function(...)
                                end");
            LuaState.DoString($"success, loadGroup{group_id} = pcall(loadfile ,\"" + script + "\"" + $", \"bt\" , _SCENE_GROUP{group_id})");
            try
            {
                LuaState.DoString($"loadGroup{group_id}()");
            }
            catch
            {
                Logger.DebugWriteLine($"Failed to load scene group: {group_id}");
                return null;
            }

            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(init_config)}"] != null)
                init_config = new(LuaState[$"_SCENE_GROUP{group_id}.{nameof(init_config)}"] as LuaTable);
            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(monsters)}"] != null)
                monsters = new List<Monster>(LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(monsters)}")).Values.Select(w => new Monster(w as LuaTable)));
            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(npcs)}"] != null)
                npcs = new List<Npc>(LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(npcs)}")).Values.Select(w => new Npc(w as LuaTable)));
            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(gadgets)}"] != null)
                gadgets = new List<Gadget>(LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(gadgets)}")).Values.Select(w => new Gadget(w as LuaTable)));
            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(regions)}"] != null)
                regions = new List<Region>(LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(regions)}")).Values.Select(w => new Region(w as LuaTable)));
            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(triggers)}"] != null)
                triggers = new List<Trigger>(LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(triggers)}")).Values.Select(w => new Trigger(w as LuaTable)));
            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(variables)}"] != null)
                variables = new List<Variable>(LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(variables)}")).Values.Select(w => new Variable(w as LuaTable)));

            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(suites)}"] != null)
                suites = new SortedList<uint, Suite>(LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(suites)}")).ToDictionary(w => (uint)(long)w.Key, w => new Suite(LuaState, w.Value as LuaTable)));

            return this;
        }
    }
}
