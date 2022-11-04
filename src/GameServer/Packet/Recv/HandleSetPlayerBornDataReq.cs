using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.SetPlayerBornDataReq)]
    internal class HandleSetPlayerBornDataReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            SetPlayerBornDataReq proto = SetPlayerBornDataReq.Parser.ParseFrom(payload);
            string heroName = proto.NickName;
            uint avatarId = proto.AvatarId;

            if (GameData.AvatarHeroEntityDataMap.ContainsKey((int)avatarId))
            {
                var newAvatar = await Avatar.CreateAsync((int)avatarId, session.Player);
                await session.Player.SetMainCharacter((int)avatarId, heroName);
                await session.Player.Avatars.AddAvatar(newAvatar, false);
                await session.Player.OnLoginAsync();
                await session.SendPacketAsync(new BasePacket(OpCode.SetPlayerBornDataRsp));
            }
            else
            {
                //TODO punish cheaters
            }
        }
    }
}
