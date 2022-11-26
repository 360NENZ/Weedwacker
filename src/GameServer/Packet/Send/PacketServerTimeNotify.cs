using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketServerTimeNotify : BasePacket
    {
        public PacketServerTimeNotify() : base(Enums.OpCode.ServerTimeNotify)
        {
            ServerTimeNotify proto = new ServerTimeNotify()
            {
                ServerTime = (ulong)DateTimeOffset.Now.ToUnixTimeMilliseconds()
            };

            Data = proto.ToByteArray();
        }
    }
}
