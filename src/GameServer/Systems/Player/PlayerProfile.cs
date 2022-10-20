using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Player
{

    public class PlayerProfile
    {
        public int NameCardId = 210001;
        public string Nickname;
        public int Level = 1;
        public int WorldLevel = 1;
        public Birthday Birthday = new() { Day = 0, Month = 0 }; // <Day,Month>
        public ProfilePicture? HeadImage; // <avatarId, skinId>
        public string? HeroName;
        public string? Signature = "";
        public int Achievements;
        public int DaysSinceLastLogin;
        public int LastActiveTime;
        public uint[]? BlacklistUidList;

        public PlayerProfile(string heroName)
        {
            HeroName = heroName;
            Nickname = heroName;
        }
    }

}
