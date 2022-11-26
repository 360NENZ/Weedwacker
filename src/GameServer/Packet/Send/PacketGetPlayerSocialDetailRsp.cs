using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketGetPlayerSocialDetailRsp : BasePacket
    {
        public PacketGetPlayerSocialDetailRsp(SocialDetail? detail) : base(Enums.OpCode.GetPlayerSocialDetailRsp)
        {
            GetPlayerSocialDetailRsp proto = new GetPlayerSocialDetailRsp();

            if (detail != null)
            {
                proto.DetailData = detail;
            }
            else
            {
                proto.Retcode = (int)Retcode.RetSvrError;
            }

            Data = proto.ToByteArray();
        }
    }
}
