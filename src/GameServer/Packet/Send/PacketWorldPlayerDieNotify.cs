using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketWorldPlayerDieNotify : BasePacket
    {
        public PacketWorldPlayerDieNotify(uint deadAvatarId, PlayerDieType playerDieType, uint killerId) : base(Enums.OpCode.WorldPlayerDieNotify)
        {
            WorldPlayerDieNotify proto = new WorldPlayerDieNotify()
            {
                MurdererEntityId = deadAvatarId,
                DieType = playerDieType,
                MonsterId = killerId,
                /*
				EntityCase =,
				GadgetId =,
				*/
            };

            Data = proto.ToByteArray();
        }
    }
}
