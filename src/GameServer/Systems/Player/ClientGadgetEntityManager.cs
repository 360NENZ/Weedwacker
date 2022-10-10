using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class ClientGadgetEntityManager
    {
        public readonly Player Owner;
        public readonly HashSet<ClientGadgetEntity> Gadgets = new();

        public ClientGadgetEntityManager(Player owner)
        {
            Owner = owner;
        }
    }
}
