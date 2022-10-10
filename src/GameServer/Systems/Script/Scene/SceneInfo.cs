using Vim.Math3d;

namespace Weedwacker.GameServer.Systems.Script.Scene
{
    internal class SceneInfo
    {
        public SceneConfig scene_config;
        public SortedList<int, int> blocks; // <index, blockId>
        public SortedList<int, Rectangle> block_rects; // <index, Rectangle>
        public HashSet<string>? dummy_points; // load dummy points from Scene<sceneId>_<string>.lua
        public HashSet<string>? routes_config; // load routes from ???

        public class SceneConfig
        {
            public Vector2 begin_pos; // x,z
            public Vector2 size; // x,z
            public Vector3 born_pos;
            public Vector3 born_rot;
            public int die_y;
            public RoomInfo room_safe_pos;
            public Vector2 vision_anchor; // x,z
        }

        public class Rectangle
        {
            public Vector2 min; // x,z
            public Vector2 max; // x,z
        }

        public class RoomInfo
        {
            public int scene_id;
            public Vector3 safe_pos;
            public Vector3 safe_rot;
        }
    }
}
