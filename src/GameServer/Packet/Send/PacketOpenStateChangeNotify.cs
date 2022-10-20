using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketOpenStateChangeNotify : BasePacket
    {
        public PacketOpenStateChangeNotify(int openState, int value) : base(Enums.OpCode.OpenStateChangeNotify)
        {
            OpenStateChangeNotify proto = new OpenStateChangeNotify();
            proto.OpenStateMap.Add((uint)openState, (uint)value);

            Data = proto.ToByteArray();
        }

        public PacketOpenStateChangeNotify(IEnumerable<Tuple<int, int>> openStates) : base(Enums.OpCode.OpenStateChangeNotify)
        {

            OpenStateChangeNotify proto = new OpenStateChangeNotify();
            foreach (var openState in openStates)
            {
                proto.OpenStateMap.Add((uint)openState.Item1, (uint)openState.Item2);
            }

            Data = proto.ToByteArray();
        }
    }
}
