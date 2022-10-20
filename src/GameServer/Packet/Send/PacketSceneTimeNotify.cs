using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSceneTimeNotify : BasePacket
    {
		public PacketSceneTimeNotify(Player player) : base(Enums.OpCode.SceneTimeNotify)
		{
			SceneTimeNotify proto = new SceneTimeNotify()
			{
				SceneId = (uint)player.SceneId,
				SceneTime = player.Scene.Time,
				IsPaused = false //TODO
			};

			Data = proto.ToByteArray();
		}
	}
}
