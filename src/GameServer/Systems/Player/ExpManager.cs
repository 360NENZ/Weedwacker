namespace Weedwacker.GameServer.Systems.Player
{
    internal class ExpManager
    {
        private Player Owner;
        public ExpManager(Player owner)
        {
            Owner = owner;
        }
        public async Task<bool> AddAdventureExp(int exp)
        {
            //TODO
            return await Owner.PropManager.SetPropertyAsync(Enums.PlayerProperty.PROP_EXP, Owner.PlayerProperties[Enums.PlayerProperty.PROP_EXP] + exp);
        }

        public async Task<bool> AddCharacterExp(Avatar.Avatar avatar, int exp)
        {
            //TODO
            return true;
        }

        public async Task<bool> AddCompanionshipExp(int exp)
        {
            //TODO
            return true;
        }

    }
}
