using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketEnterSceneDoneRsp : BasePacket
    {
        public PacketEnterSceneDoneRsp(Player player) : base(Enums.OpCode.EnterSceneDoneRsp)
        {
            EnterSceneDoneRsp p = new EnterSceneDoneRsp()
            {
                EnterSceneToken = player.EnterSceneToken
            };

            Data = p.ToByteArray();
        }
    }
}
