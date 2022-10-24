using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class GadgetWorktop : BaseGadgetEntity
    {
        public HashSet<int> WorktopOptions;

        public GadgetWorktop(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            throw new NotImplementedException();
        }
    }
}
