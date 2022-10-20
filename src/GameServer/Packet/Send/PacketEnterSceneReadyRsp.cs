using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketEnterSceneReadyRsp : BasePacket
    {
		public PacketEnterSceneReadyRsp(Player player, uint token) : base(Enums.OpCode.EnterSceneReadyRsp, 11)
		{
			EnterSceneReadyRsp p = new EnterSceneReadyRsp();
			if (token == player.EnterSceneToken)
				p.EnterSceneToken = token;
			else
				p.Retcode = (int)Retcode.RetEnterSceneTokenInvalid;

			Data = p.ToByteArray();
		}
	}
}
