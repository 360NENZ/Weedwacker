using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;

namespace Weedwacker.GameServer.Systems.World
{
    internal abstract class BaseGadgetEntity : ScriptEntity
    {
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
