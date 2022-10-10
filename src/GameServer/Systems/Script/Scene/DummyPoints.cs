using Vim.Math3d;

namespace Weedwacker.GameServer.Systems.Script.Scene
{
    internal class DummyPoints
    {
        public Dictionary<string, Position> dummy_points;

        public class Position
        {
            public Vector3 pos;
            public Vector3 rot;
        }
    }
}
