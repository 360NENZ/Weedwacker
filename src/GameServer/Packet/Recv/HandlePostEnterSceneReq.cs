using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.PostEnterSceneReq)]
    internal class HandlePostEnterSceneReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            if (session.Player.Scene.SceneData.type == SceneType.SCENE_ROOM)
            {
                //await session.Player.QuestManager.TriggerEventAsync(QuestTrigger.QUEST_CONTENT_ENTER_ROOM, session.Player.SceneId, 0);
            }

            await session.SendPacketAsync(new PacketPostEnterSceneRsp(session.Player));
        }
    }
}
