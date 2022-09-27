using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPlayerPropChangeNotify : BasePacket
    {
        public PacketPlayerPropChangeNotify(PlayerProperty prop, int diff) : base(OpCode.PlayerPropChangeNotify)
        {
            BuildHeader(0);

            PlayerPropChangeNotify proto = new PlayerPropChangeNotify()
            {
                PropType = (uint)prop,
                PropDelta = (uint)diff
            };

            Data = proto.ToByteArray();
        }
    }
}
