namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPlayerSetPauseRsp : BasePacket
    {
        public PacketPlayerSetPauseRsp(uint clientSequence) : base(Enums.OpCode.PlayerSetPauseRsp)
        {
            BuildHeader(clientSequence);
        }
    }
}
