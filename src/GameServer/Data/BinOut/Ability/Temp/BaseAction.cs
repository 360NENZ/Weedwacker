using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal abstract class BaseAction
    {
        public virtual async Task Execute(string abilityName, AvatarEntity avatar, SceneEntity enemyTarget = null)
        {

        }
    }
}
