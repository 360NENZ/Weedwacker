using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSyncScenePlayTeamEntityNotify : BasePacket
    {
		public PacketSyncScenePlayTeamEntityNotify(Player player) : base(Enums.OpCode.SyncScenePlayTeamEntityNotify)
		{
			SyncScenePlayTeamEntityNotify proto = new SyncScenePlayTeamEntityNotify()
			{
				SceneId = (uint)player.SceneId
			};
			//TODO proto.EntityInfoList.Add()

			Data = proto.ToByteArray();
		}
	}
}
