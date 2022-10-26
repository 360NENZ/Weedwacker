using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPlayerTimeNotify : BasePacket
    {
        public PacketPlayerTimeNotify(Player player) : base(OpCode.PlayerTimeNotify)
        {
            PlayerTimeNotify p = new()
            {
                IsPaused = player.Paused,
                PlayerTime = player.Session.ClientTime,
                ServerTime = (ulong)DateTimeOffset.Now.ToUnixTimeMilliseconds()
            };

            Data = p.ToByteArray();
        }
    }
}
