using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    public interface IInvocation
    {
        internal Task Invoke(string abilityName, BaseEntity srcEntity, SceneEntity? targetEntity = null);
    }
}
