using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class BattlePassManager
    {
        private readonly Player Owner;

        public BattlePassManager(Player owner)
        {
            Owner = owner;
        }

        internal void TriggerMission(WatcherTriggerType tRIGGER_COST_MATERIAL, int v, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
