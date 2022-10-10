using Vim.Math3d;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Systems.Script.Scene
{
    internal class SceneGroup
    {
        public uint group_id;
        public List<Monster>? monsters;
        public List<Npc>? npcs;
        public List<Gadget>? gadgets;
        public List<Region>? regions;
        public List<Trigger>? triggers;
        public SortedList<uint, Suite> suites; 
        public InitConfig init_config;

        public class Suite
        {
            public List<uint>? monsters; // config_id
            public List<uint>? npcs; // config_id
            public List<uint>? gadgets; // config_id
            public List<uint>? regions; // config_id
            public List<string>? triggers; // substring of trigger's name/action
            public uint rand_weight;

        }

        public abstract class SpawnInfo
        {
            public uint config_id;
            public Vector3 pos;
            public Vector3 rot;
        }
        public class InitConfig
        {
            public uint suite;
            public uint end_suite;
            public bool rand_suite;
        }
        public class Monster : SpawnInfo
        {
            public uint monster_id;
            public uint level;
            public string? drop_tag;
            public uint pose_id;
            public uint area_id;
        }

        public class Npc : SpawnInfo
        {
            public uint npc_id;
            public uint area_id;
        }

        public class Gadget : SpawnInfo
        {
            
            public uint gadget_id;
            public uint level;
            public string? drop_tag;
            public uint area_id;
            public uint route_id;
            public bool showcutscene;
            public bool isOneoff;
            public bool persistent;
            public Explore? explore;

            public class Explore
            {
                public string name;
                public uint exp;                
            }
        }

        public class Region
        {
            public uint config_id;
            public RegionShape shape;
            public uint radius;
            public Vector3 pos;
            public uint area_id;
        }

        public class Trigger
        {
            public uint config_id;
            public string name;
            public EventType _event; // It's "event" in the lua files, but event is a c# keyword ;_;
            public string source;
            public string condition;
            public string action;
            public uint trigger_count;
        }

        // for reference
        struct SeelieVariable1
        {
            public uint point_sum;
            public uint route_2;
            public uint gadget_seelie;
            public uint final_point;
        }
    }
}
