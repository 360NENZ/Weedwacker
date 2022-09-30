
namespace Weedwacker.GameServer.Systems.Player.ItemUseOp
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ItemUseAttribute : Attribute
    {
        /* Enum of the operation */
        public readonly Enums.ItemUseOp Op;

        public ItemUseAttribute(Enums.ItemUseOp op)
        {
            Op = op;
        }
    }
}
