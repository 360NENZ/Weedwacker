using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.AbilityInvocationsNotify)]
    internal class HandleAbilityInvocationsNotify : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            AbilityInvocationsNotify proto = AbilityInvocationsNotify.Parser.ParseFrom(payload);
            foreach (var invoke in proto.Invokes)
            {
                session.Player.AbilityInvNotifyList.AddEntry(invoke, invoke.ForwardType, invoke.ForwardPeer);
                //invoke.Head.
            }
        }
    }
}
