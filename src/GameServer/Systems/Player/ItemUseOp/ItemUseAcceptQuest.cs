namespace Weedwacker.GameServer.Systems.Player.ItemUseOp
{
    [ItemUse(Enums.ItemUseOp.ITEM_USE_ACCEPT_QUEST)]
    internal class ItemUseAcceptQuest : BaseItemUse
    {
        public ItemUseAcceptQuest(Player user, int itemId) : base(user, itemId)
        {
        }

        internal override Task<bool> Use()
        {
            throw new NotImplementedException();
        }
    }
}
