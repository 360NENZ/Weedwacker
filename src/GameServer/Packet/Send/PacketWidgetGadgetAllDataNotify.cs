using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketWidgetGadgetAllDataNotify : BasePacket
    {
        public PacketWidgetGadgetAllDataNotify() : base(OpCode.WidgetGadgetAllDataNotify)
        {
            WidgetGadgetAllDataNotify p = new();

            Data = p.ToByteArray();
        }
    }
}
