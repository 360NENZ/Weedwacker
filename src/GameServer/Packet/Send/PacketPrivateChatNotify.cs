using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPrivateChatNotify : BasePacket
    {
        public PacketPrivateChatNotify(uint senderUid, uint targetUid, string text) : base(OpCode.PrivateChatNotify)
        {
            PrivateChatNotify proto = new PrivateChatNotify()
            {
                ChatInfo = new ChatInfo()
                {
                    Uid = senderUid,
                    ToUid = targetUid,
                    Text = text,
                    Time = (uint)DateTimeOffset.Now.Second
                }
            };

            Data = proto.ToByteArray();
        }
    }
}
