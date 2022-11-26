using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketClientAbilityInitFinishNotify : BasePacket
    {
        public PacketClientAbilityInitFinishNotify(IEnumerable<AbilityInvokeEntry> entries) : base(Enums.OpCode.ClientAbilityInitFinishNotify, true)
        {
            ClientAbilityInitFinishNotify proto = new ClientAbilityInitFinishNotify()
            {
                EntityId = entries.First().EntityId
            };
            proto.Invokes.AddRange(entries);

            Data = proto.ToByteArray();
        }
    }
}
