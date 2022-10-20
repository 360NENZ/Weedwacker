using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSetOpenStateRsp : BasePacket
    {
        public PacketSetOpenStateRsp(uint openState, uint value) : base(Enums.OpCode.SetOpenStateRsp)
        {
            SetOpenStateRsp proto = new SetOpenStateRsp()
            {
                Key = openState,
                Value = value
            };

            Data = proto.ToByteArray();
        }

        public PacketSetOpenStateRsp(Retcode retcode) : base(Enums.OpCode.SetOpenStateRsp)
        {
            SetOpenStateRsp proto = new SetOpenStateRsp()
            {
                Retcode = (int)retcode
            };

            Data = proto.ToByteArray();
        }
    }
}
