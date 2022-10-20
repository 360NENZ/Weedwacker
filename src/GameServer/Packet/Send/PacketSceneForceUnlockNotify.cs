using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSceneForceUnlockNotify : BasePacket
    {
        /*
         * 1,
         * 47,
         * 37,
         * What do the numbers mean???
         */
        public PacketSceneForceUnlockNotify() : base(Enums.OpCode.SceneForceUnlockNotify)
        {
            SceneForceUnlockNotify p = new()
            {
                /* TODO
                IsAdd = ,
                ForceIdList =
                */
            };

            Data = p.ToByteArray();
        }
    }
}
