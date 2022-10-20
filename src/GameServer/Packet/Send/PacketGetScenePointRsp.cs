using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketGetScenePointRsp : BasePacket
    {
        public PacketGetScenePointRsp(Player player, uint SceneId) : base(Enums.OpCode.GetScenePointRsp)
        {
            GetScenePointRsp p = new()
            {
                SceneId = SceneId,
            };
            HashSet<int>? points = player.ProgressManager.UnlockedScenePoints.GetValueOrDefault((int)SceneId);
            if (points != null) p.UnlockedPointList.AddRange(points.Select(w => (uint)w));

            Data = p.ToByteArray();
        }
    }
}
