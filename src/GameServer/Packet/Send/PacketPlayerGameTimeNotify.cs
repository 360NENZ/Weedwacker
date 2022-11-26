using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPlayerGameTimeNotify : BasePacket
    {
        public PacketPlayerGameTimeNotify(Player player) : base(Enums.OpCode.PlayerGameTimeNotify)
        {
            PlayerGameTimeNotify proto = new PlayerGameTimeNotify()
            {
                GameTime = player.Scene.Time,
                Uid = (uint)player.GameUid,
                //IsHome = TODO
            };

            Data = proto.ToByteArray();
        }
    }
}
