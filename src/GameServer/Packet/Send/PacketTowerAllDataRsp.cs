using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketTowerAllDataRsp : BasePacket
    {
        //TODO
        public PacketTowerAllDataRsp() : base(OpCode.TowerAllDataRsp)
        {
            TowerAllDataRsp p = new() { Retcode = (int)Retcode.RetTowerNotOpen };

            Data = p.ToByteArray();
        }
    }
}
