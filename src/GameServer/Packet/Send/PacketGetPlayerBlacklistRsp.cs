using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketGetPlayerBlacklistRsp : BasePacket
    {
        public PacketGetPlayerBlacklistRsp(Player player) : base(Enums.OpCode.GetPlayerBlacklistRsp, 3)
        {
            GetPlayerBlacklistRsp proto = new();
            if (player.SocialManager.BlackList != null && player.SocialManager.BlackList.Any())
                player.SocialManager.BlackList.AsParallel().ForAll(w => proto.Blacklist.Add(w.Value.ToProto()));

            Data = proto.ToByteArray();
        }
    }
}
