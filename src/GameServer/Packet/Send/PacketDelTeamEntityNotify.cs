using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketDelTeamEntityNotify : BasePacket
    {
		public PacketDelTeamEntityNotify(int sceneId, uint teamEntityId) : base(Enums.OpCode.DelTeamEntityNotify)
		{
			DelTeamEntityNotify proto = new DelTeamEntityNotify()
			{
				SceneId = (uint)sceneId,
			};
			proto.DelEntityIdList.Add(teamEntityId);

			Data = proto.ToByteArray();
		}
	}
}
