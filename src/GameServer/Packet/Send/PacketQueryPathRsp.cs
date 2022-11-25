using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketQueryPathRsp : BasePacket
    {
        public PacketQueryPathRsp(QueryPathReq req) : base(Enums.OpCode.QueryPathRsp)
        {
            var proto = new QueryPathRsp() { QueryId = req.QueryId, QueryStatus = QueryPathRsp.Types.PathStatusType.Succ };

            proto.Corners.Add(req.SourcePos);
            proto.Corners.Add(req.DestinationPos[0]);

            Data = proto.ToByteArray();
        }
    }
}
