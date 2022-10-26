using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.EnterSceneDoneReq)]
    internal class HandleEnterSceneDoneReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            // Finished loading
            session.Player.SceneLoadState = SceneLoadState.LOADED;

            // Done

            // Spawn player in world
            await session.Player.Scene.SpawnPlayerAsync(session.Player);

            // Spawn other entites already in world
            await session.Player.Scene.ShowOtherEntitiesAsync(session.Player);

            // Locations
            await session.SendPacketAsync(new PacketWorldPlayerLocationNotify(session.Player.World));
            await session.SendPacketAsync(new PacketScenePlayerLocationNotify(session.Player.Scene));
            await session.SendPacketAsync(new PacketWorldPlayerRTTNotify(session.Player.World));

            //Rsp
            await session.SendPacketAsync(new PacketEnterSceneDoneRsp(session.Player));
        }
    }
}
