using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketGetPlayerAskFriendListRsp : BasePacket
    {
        //TODO
        public PacketGetPlayerAskFriendListRsp(Player player) : base(OpCode.GetPlayerAskFriendListRsp)
        {
            GetPlayerAskFriendListRsp p = new();

            Data = p.ToByteArray();
        }
    }
}
