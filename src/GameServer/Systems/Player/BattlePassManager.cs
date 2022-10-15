using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class BattlePassManager
    {
        private Player Owner;

        public BattlePassManager(Player owner)
        {
            Owner = owner;
        }

        internal void TriggerMission(WatcherTriggerType triggerType, int v, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
