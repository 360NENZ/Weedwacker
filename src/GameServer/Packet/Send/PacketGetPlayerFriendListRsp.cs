using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketGetPlayerFriendListRsp : BasePacket
    {
        public PacketGetPlayerFriendListRsp(Player player) : base(Enums.OpCode.GetPlayerFriendListRsp)
        {
            GetPlayerFriendListRsp proto = new GetPlayerFriendListRsp();

            var serverAccount = GameServer.Configuration.Server.ServerAccount;
            FriendBrief serverFriend = new FriendBrief()
            {
                Uid = (uint)GameServer.Configuration.Server.GameOptions.Constants.SERVER_CONSOLE_UID,
                Nickname = serverAccount.NickName,
                Level = (uint)serverAccount.AdventureRank,
                ProfilePicture = new() { AvatarId = (uint)serverAccount.AvatarId },
                WorldLevel = (uint)serverAccount.WorldLevel,
                Signature = serverAccount.Signature,
                LastActiveTime = (uint)DateTime.Now.Second,
                NameCardId = (uint)serverAccount.NameCardId,
                OnlineState = FriendOnlineState.Online,
                Param = 1, // Days since last login
                IsGameSource = true, //TODO?
                PlatformType = PlatformType.CloudTv,
            };

            proto.FriendList.Add(serverFriend);
            player.SocialManager.Friends.Values.AsParallel().ForAll(w => proto.FriendList.Add(w.ToProto()));

            Data = proto.ToByteArray();
        }
    }
}
