using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketCombatInvocationsNotify : BasePacket
    {
		public PacketCombatInvocationsNotify(CombatInvokeEntry entry) : base(Enums.OpCode.CombatInvocationsNotify, true)
		{
			CombatInvocationsNotify proto = new CombatInvocationsNotify();
			proto.InvokeList.Add(entry);

			Data = proto.ToByteArray();
		}

		public PacketCombatInvocationsNotify(IEnumerable<CombatInvokeEntry> entries) : base(Enums.OpCode.CombatInvocationsNotify, true)
		{
			CombatInvocationsNotify proto = new CombatInvocationsNotify();
			proto.InvokeList.AddRange(entries);

			Data = proto.ToByteArray();
		}
	}
}
