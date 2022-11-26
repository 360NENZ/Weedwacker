using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarGainFlycloakNotify : BasePacket
    {
        public PacketAvatarGainFlycloakNotify(int flycloak) : base(Enums.OpCode.AvatarGainFlycloakNotify)
        {
            AvatarGainFlycloakNotify proto = new AvatarGainFlycloakNotify() { FlycloakId = (uint)flycloak };

            Data = proto.ToByteArray();
        }
    }
}
