using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal class LocalIdGenerator
    {
        public ConfigAbilitySubContainerType Type = ConfigAbilitySubContainerType.NONE;
        public uint ConfigIndex = 0;
        public uint MixinIndex = 0;
        private uint ActionIndex = 0;

        public LocalIdGenerator(ConfigAbilitySubContainerType type)
        {
            if (type == ConfigAbilitySubContainerType.NONE) throw new Exception();
            Type = type;
        }

        public void InitializeActionLocalIds(BaseAction[]? actions, Dictionary<uint, IInvocation> localIdToInvocationMap)
        {
            if (actions == null) return;
            ActionIndex = 0;
            for (ushort i = 0; i < actions.Length; i++)
            {
                ActionIndex++;
                uint id = GetLocalId();
                localIdToInvocationMap[id] = actions[i];
            }
            ActionIndex = 0;
        }

        public uint GetLocalId()
        {
            switch (Type)
            {
                case ConfigAbilitySubContainerType.ACTION:
                    return 8 * ConfigIndex + 0x200 * ActionIndex + 1;
                case ConfigAbilitySubContainerType.MIXIN:
                    return 0;
                case ConfigAbilitySubContainerType.MODIFIER_ACTION:
                    return 0;
                case ConfigAbilitySubContainerType.MODIFIER_MIXIN:
                    return 0;
                default:
                    Logger.WriteErrorLine("Invalid ConfigAbilitySubContainerType");
                    return 0;
            }
        }
    }
}
