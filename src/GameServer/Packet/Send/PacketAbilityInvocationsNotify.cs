using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAbilityInvocationsNotify : BasePacket
    {
        public PacketAbilityInvocationsNotify(AbilityInvokeEntry entry) : base(Enums.OpCode.AbilityInvocationsNotify, true)
        {
            AbilityInvocationsNotify proto = new AbilityInvocationsNotify();
            proto.Invokes.Add(entry);

            Data = proto.ToByteArray();
        }

        public PacketAbilityInvocationsNotify(IEnumerable<AbilityInvokeEntry> entries) : base(Enums.OpCode.AbilityInvocationsNotify, true)
        {
            AbilityInvocationsNotify proto = new AbilityInvocationsNotify();
            proto.Invokes.AddRange(entries);

            Data = proto.ToByteArray();
        }

    }
}
