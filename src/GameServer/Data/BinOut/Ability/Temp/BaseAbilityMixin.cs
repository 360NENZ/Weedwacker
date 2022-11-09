using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal abstract class BaseAbilityMixin : IInvocation
    {
        public virtual async Task Invoke(string abilityName, BaseEntity srcEntity, SceneEntity? targetEntity = null)
        {
            await Task.Yield();
        }

        public virtual async Task Initialize(LocalIdGenerator idGenerator, IDictionary<uint, IInvocation> localIdToInvocationMap)
        {
            await Task.Yield();
            uint id = idGenerator.GetLocalId();
            localIdToInvocationMap[id] = this;
            /*
            idGenerator.ConfigIndex = 0;
            for(BaseAction[] actions in BaseAction[][] containrer)
            {
                for(BaseAction action)
                {
                    idGenerator.InitializeActionLocalIds
                }
                idGenerator.ConfigIndex++;
            }
            idGenerator.ConfigIndex = 0;
            */
        }
    }
}
