using Google.Protobuf;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarAddNotify : BasePacket
    {
        public PacketAvatarAddNotify(Avatar avatar, bool isInTeam) : base(Enums.OpCode.AvatarAddNotify)
        {
            AvatarAddNotify proto = new AvatarAddNotify()
            {
                Avatar = avatar.ToProto(),
                IsInTeam = isInTeam
            };

            Data = proto.ToByteArray();
        }
    }
}
