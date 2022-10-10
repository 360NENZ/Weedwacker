using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Player
{

    public class PlayerProfile
    {
        public int NameCardId;
        public string? Nickname;
        public Tuple<int, int>? Birthday; // <Day,Month>
        public ProfilePicture? HeadImage; // <avatarId, skinId>
        public string? HeroName;
        public string? Signature;
        public int Achievements;
        public int LastActiveTime;
        public uint[]? BlacklistUidList;
    }

}
