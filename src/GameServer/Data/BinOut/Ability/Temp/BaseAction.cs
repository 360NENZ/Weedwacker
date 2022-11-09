using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal abstract class BaseAction : IInvocation
    {
        public virtual async Task Invoke(string abilityName, BaseEntity srcEntity, SceneEntity? targetEntity = null)
        {

        }
    }
}
