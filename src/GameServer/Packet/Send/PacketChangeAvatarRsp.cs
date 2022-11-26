using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketChangeAvatarRsp : BasePacket
    {
        public PacketChangeAvatarRsp(ulong guid) : base(Enums.OpCode.ChangeAvatarRsp)
        {
            ChangeAvatarRsp p = new ChangeAvatarRsp()
            {
                Retcode = (int)Retcode.RetSucc,
                CurGuid = guid,
            };

            Data = p.ToByteArray();
        }
    }
}
