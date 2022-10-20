using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPostEnterSceneRsp : BasePacket
    {
		public PacketPostEnterSceneRsp(Player player) : base(Enums.OpCode.PostEnterSceneRsp)
		{
			PostEnterSceneRsp p = new PostEnterSceneRsp()
			{
				EnterSceneToken = player.EnterSceneToken
			};

			Data = p.ToByteArray();
		}
	}
}
