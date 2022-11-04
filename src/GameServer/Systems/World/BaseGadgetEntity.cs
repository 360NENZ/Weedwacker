using Vim.Math3d;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;

namespace Weedwacker.GameServer.Systems.World
{
    internal abstract class BaseGadgetEntity : ScriptEntity
    {
        public override Vector3 Position { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public override Vector3 Rotation { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public GadgetData Data => GameData.GadgetDataMap[GadgetId];
        public int GadgetId { get; protected set; }

        
        protected BaseGadgetEntity(Scene? scene) : base(scene)
        {
            // USE ONLY FOR CLIENT GADGETS. WHO NEEDS MULTIPLE INHERITANCE ANYWAY?!
        }

        protected BaseGadgetEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {

        }
    }
}
