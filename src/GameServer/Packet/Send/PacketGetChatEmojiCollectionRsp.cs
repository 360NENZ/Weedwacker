using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketGetChatEmojiCollectionRsp : BasePacket
    {
        public PacketGetChatEmojiCollectionRsp(Player player) : base(Enums.OpCode.GetChatEmojiCollectionRsp)
        {
            GetChatEmojiCollectionRsp proto = new();

            if (player.SocialManager.EmojiIdList != null && player.SocialManager.EmojiIdList.Any())
                player.SocialManager.EmojiIdList.AsParallel().ForAll(w => proto.ChatEmojiCollectionData.EmojiIdList.Add((uint)w));

            Data = proto.ToByteArray();
        }
    }
}
