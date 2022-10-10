using Vim.Math3d;

namespace Weedwacker.GameServer.Systems.Script.Scene
{
    internal class SceneBlock
    {
        public SortedList<int, SceneGroupInfo> groups;

        public class SceneGroupInfo
        {
            public uint id;
            public uint area;           
            public Vector3 pos;
            public List<uint>? related_level_tag_series_list;
            public List<Dictionary<string, uint>>? life_cycle; // list of pairs "from": number, and "to": number
            public bool dynamic_load;
            public uint load_strategy;
            public int refresh_id;
            public bool limit_drop;
            public IsReplacable? is_replaceable;
            public bool force_unload_nodelay;
            public uint vision_type;
            public Business? business;
            public bool is_ignore_world_level_revise;
            public uint activity_revise_level_grow_id;

            public class IsReplacable
            {
                public bool value;
                public uint version;
                public bool new_bin_only;
            }
            public class Business
            {
                public uint type;
            }
        }
    }
}
