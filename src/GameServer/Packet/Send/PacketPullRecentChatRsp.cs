using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPullRecentChatRsp : BasePacket
    {
        //TODO
        public PacketPullRecentChatRsp() : base(OpCode.PullRecentChatRsp)
        {
            PullRecentChatRsp proto = new()
            {
                Retcode = 0
            };

            Data = proto.ToByteArray();
        }
    }
}
