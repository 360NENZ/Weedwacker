using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class EnergyManager
    {
        private Player Owner;

        public EnergyManager(Player player)
        {
            Owner = player;
        }

        internal void HandleMonsterEnergyDrop(MonsterEntity monsterEntity, float hpBeforeDamage, float hpAfterDamage)
        {
            throw new NotImplementedException();
        }
    }
}