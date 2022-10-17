using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.GetChatEmojiCollectionReq)]
    internal class HandleGetChatEmojiCollectionReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            await session.SendPacketAsync(new PacketGetChatEmojiCollectionRsp(session.Player));
        }
    }
}
