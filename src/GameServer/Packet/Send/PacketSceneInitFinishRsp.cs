using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSceneInitFinishRsp : BasePacket
    {
        public PacketSceneInitFinishRsp(Player player) : base(Enums.OpCode.SceneInitFinishRsp, 11)
        {
            SceneInitFinishRsp p = new SceneInitFinishRsp() { EnterSceneToken = player.EnterSceneToken };

            Data = p.ToByteArray();
        }
    }
}
