namespace Weedwacker.GameServer.Systems.World
{
    internal abstract class ScriptEntity : GameEntity
    {
        public readonly uint BlockId;
        public readonly uint GroupId;
        public uint ConfigId { get; protected set; }
        
        public ScriptEntity(Scene? scene) : base(scene)
        {
            // USE ONLY FOR CLIENT GADGETS. WHO NEEDS MULTIPLE INHERITANCE ANYWAY?!
        }

        protected ScriptEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene)
        {
            BlockId = blockId;
            GroupId = groupId;
            ConfigId = configId;
        }
    }
}
