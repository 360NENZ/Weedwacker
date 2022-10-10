namespace Weedwacker.GameServer.Systems.World
{
    internal abstract class BaseGadgetEntity : ScriptEntity
    {
        public int GadgetId { get; protected set; }

        // USE ONLY FOR CLIENT GADGETS. WHO NEEDS MULTIPLE INHERITANCE ANYWAY?!
        protected BaseGadgetEntity(Scene? scene) : base(scene)
        {

        }

        protected BaseGadgetEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {

        }
    }
}
