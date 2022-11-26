using Google.Protobuf;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketWorldPlayerInfoNotify : BasePacket
    {
        public PacketWorldPlayerInfoNotify(World world) : base(Enums.OpCode.WorldPlayerInfoNotify)
        {

            WorldPlayerInfoNotify proto = new();

            proto.PlayerInfoList.AddRange(world.Players.Select(p => p.GetOnlinePlayerInfo()));
            proto.PlayerUidList.AddRange(world.Players.Select(p => (uint)p.GameUid));

            Data = proto.ToByteArray();
        }
    }
}
