using Google.Protobuf;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketOpenStateUpdateNotify : BasePacket
    {
        public PacketOpenStateUpdateNotify(Player player) : base(Enums.OpCode.OpenStateUpdateNotify)
        {
            OpenStateUpdateNotify proto = new OpenStateUpdateNotify();

            foreach ( var openState in player.OpenStates)
            {
                proto.OpenStateMap.Add((uint)openState.Key, (uint)openState.Value);
            }

            Data = proto.ToByteArray();
        }
    }
}
