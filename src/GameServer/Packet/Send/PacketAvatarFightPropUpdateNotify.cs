using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarFightPropUpdateNotify : BasePacket
    {
        public PacketAvatarFightPropUpdateNotify(Avatar avatar, FightProperty prop) : base(OpCode.AvatarFightPropUpdateNotify)
        {
            AvatarFightPropUpdateNotify proto = new()
            {
                AvatarGuid = (ulong)avatar.Guid           
            };

            proto.FightPropMap.Add((uint)prop, avatar.FightProp[prop]);

            Data = proto.ToByteArray();
        }
    }
}
