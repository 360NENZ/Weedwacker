using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPathfindingEnterSceneRsp : BasePacket
    {
        public PacketPathfindingEnterSceneRsp(uint clientSequence) : base(OpCode.PathfindingEnterSceneRsp, clientSequence)
        {
        }
    }
}
