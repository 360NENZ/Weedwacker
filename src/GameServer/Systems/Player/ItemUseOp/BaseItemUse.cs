using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;

namespace Weedwacker.GameServer.Systems.Player.ItemUseOp
{
    internal abstract class BaseItemUse
    {
        protected Player User;
        protected MaterialData ItemData;

        public BaseItemUse(Player user, int itemId)
        {
            User = user;
            ItemData = (MaterialData)GameData.ItemDataMap[itemId];
        }
        internal abstract Task<bool> Use();
    }
}
