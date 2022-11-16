using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPrivateChatRsp : BasePacket
    {
        public PacketPrivateChatRsp() : base(OpCode.PrivateChatRsp)
        {
            var rsp = new PrivateChatRsp();

            Data = rsp.ToByteArray();
        }
    }
}
