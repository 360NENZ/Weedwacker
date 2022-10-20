using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketGetSceneAreaRsp : BasePacket
    {
        public PacketGetSceneAreaRsp(Player player, uint sceneId) : base(Enums.OpCode.GetSceneAreaRsp, 0)
        {
            GetSceneAreaRsp p = new()
            {
                SceneId = sceneId
            };

            HashSet<int>? areas = player.ProgressManager.UnlockedSceneAreas.GetValueOrDefault((int)sceneId);
            if (areas != null) p.AreaIdList.AddRange(areas.Select(w => (uint)w));

            Data = p.ToByteArray();
        }
    }
}
