using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Inventory
{
    //TODO
    internal class FurnitureItem : GameItem
    {
        public FurnitureItem(long guid, int itemId, int count) : base(guid, itemId, count)
        {
        }

        public override Item ToProto()
        {
            throw new NotImplementedException();
        }
    }
}
