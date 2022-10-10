using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarTeamUpdateNotify : BasePacket
    {
        public PacketAvatarTeamUpdateNotify(Player owner) : base(Enums.OpCode.AvatarTeamUpdateNotify)
        {
            AvatarTeamUpdateNotify proto = new();

            owner.TeamManager.Teams.AsParallel().ForAll(w => proto.AvatarTeamMap.Add((uint)w.Key, w.Value.ToProto(owner)));

            Data = proto.ToByteArray();
        }
    }
}
