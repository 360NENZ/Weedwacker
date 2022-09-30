namespace Weedwacker.GameServer.Systems.Player.ItemUseOp
{
    internal abstract class BaseItemUse
    {
        internal abstract Task<bool> Use();
    }
}
