namespace Weedwacker.GameServer.Systems.World
{
    internal abstract class ScriptEntity : GameEntity
    {
        public readonly uint BlockId;
        public readonly uint GroupId;
        public uint ConfigId { get; protected set; }

        // USE ONLY FOR CLIENT GADGETS. WHO NEEDS MULTIPLE INHERITANCE ANYWAY?!
        public ScriptEntity(Scene? scene) : base(scene)
        {
        }

        protected ScriptEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene)
        {
            BlockId = blockId;
            GroupId = groupId;
            ConfigId = configId;
        }
    }
}
