using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarUnlockTalentNotify : BasePacket
    {
        public PacketAvatarUnlockTalentNotify(Avatar avatar, int depotId, int talentId) : base(OpCode.AvatarUnlockTalentNotify)
        {

            AvatarUnlockTalentNotify proto = new AvatarUnlockTalentNotify()
            {
                AvatarGuid = avatar.Guid,
                EntityId = (uint)avatar.EntityId,
                TalentId = (uint)talentId,
                SkillDepotId = (uint)depotId
            };

            Data = proto.ToByteArray();
        }
    }
}
