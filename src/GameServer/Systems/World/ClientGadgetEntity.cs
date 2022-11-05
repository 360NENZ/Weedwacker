using Vim.Math3d;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    // BOY I'M SURE HAPPY I DON'T HAVE TO DEAL WITH MULTIPLE INHERITANCE... WHAT A HEADACHE
    internal class ClientGadgetEntity : BaseGadgetEntity
    {
        public readonly Player.Player Owner;

        public readonly int CampId;
        public readonly int CampType;
        public readonly uint OwnerEntityId;
        public readonly uint TargetEntityId;
        public readonly bool AsyncLoad;

        public readonly uint OriginalOwnerEntityId;

        public ClientGadgetEntity(Scene scene, Player.Player player, EvtCreateGadgetNotify notify) : base(scene)
        {
            Owner = player;
            EntityId = notify.EntityId;
            Position = new(notify.InitPos.X, notify.InitPos.Y, notify.InitPos.Z);
            Rotation = new(notify.InitEulerAngles.X, notify.InitEulerAngles.Y, notify.InitEulerAngles.Z);
            ConfigId = notify.ConfigId;
            CampId = (int)notify.CampId;
            CampType = (int)notify.CampType;
            OwnerEntityId = notify.PropOwnerEntityId;
            TargetEntityId = notify.TargetEntityId;
            AsyncLoad = notify.IsAsyncLoad;

            SceneEntity owner = scene.GetEntityById(OwnerEntityId) as SceneEntity;
            if (owner is ClientGadgetEntity ownerGadget) {
                OriginalOwnerEntityId = ownerGadget.OriginalOwnerEntityId;
            }
            else
            {
                OriginalOwnerEntityId = OwnerEntityId;
            }
        }

        public override async Task OnDeathAsync(uint killerId)
        {
            await base.OnDeathAsync(killerId); // Invoke base class's onDeath() method.
        }

        public override SceneEntityInfo ToProto()
        {
            //TODO
            EntityAuthorityInfo authority = new EntityAuthorityInfo()
            {
                AbilityInfo = new AbilitySyncStateInfo(),
                RendererChangedInfo = new(),
                AiInfo = new() { IsAiOpen = true, BornPos = new() },
                BornPos = new()
            };

            SceneEntityInfo entityInfo = new SceneEntityInfo()
            {
                EntityId = EntityId,
                EntityType = ProtEntityType.Gadget,
                MotionInfo = GetMotionInfo(),
                EntityClientData = new(),
                EntityAuthorityInfo = authority,
                LifeState = (uint)LifeState.LIFE_ALIVE
            };
            entityInfo.AnimatorParaList.Add(new AnimatorParameterValueInfoPair());

            PropPair pair = new PropPair()
            {
                Type = (uint)PlayerProperty.PROP_LEVEL,
                PropValue = new() { Type = (uint)PlayerProperty.PROP_LEVEL, Val = 1 }
            };
            entityInfo.PropList.Add(pair);

            ClientGadgetInfo clientGadget = new ClientGadgetInfo()
            {
                CampId = (uint)CampId,
                CampType = (uint)CampType,
                OwnerEntityId = OwnerEntityId,
                TargetEntityId = TargetEntityId,
                AsyncLoad = AsyncLoad
            };

            SceneGadgetInfo gadgetInfo = new SceneGadgetInfo()
            {
                GadgetId = (uint)GadgetId,
                OwnerEntityId = OwnerEntityId,
                IsEnableInteract = true,
                ClientGadget = clientGadget,
                PropOwnerEntityId = OwnerEntityId,
                AuthorityPeerId = Scene.World.Host.PeerId
            };

            entityInfo.Gadget = gadgetInfo;

            return entityInfo;
        }
    }
}
