using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class ClientGadgetEntityManager
    {
        private Player Owner;
        public HashSet<ClientGadgetEntity> Gadgets { get; private set; } = new();

        public ClientGadgetEntityManager(Player owner)
        {
            Owner = owner;
        }
    }
}
