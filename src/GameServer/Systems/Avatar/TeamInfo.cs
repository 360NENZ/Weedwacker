using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Avatar
{
    internal class TeamInfo
    {
        public string TeamName;
        [BsonElement] public SortedList<int, Avatar> AvatarInfo { get; private set; } = new(); // <index, avatar>> clone avatars for abyss teams
        public List<TeamResonanceData> TeamResonances = new();
        public readonly bool IsTowerTeam = false; //Don't allow any further team editing if it's an abyss team
        public TeamInfo(string name = "")
        {
            TeamName = name;
        }

        public TeamInfo(IEnumerable<Avatar> avatars, string name = "", bool isTowerTeam = false)
        {
            TeamName = name;
            IsTowerTeam = false;
            int index = 0;
            avatars.AsParallel().ForAll(a => AddAvatar(a, index++));
            IsTowerTeam = isTowerTeam;
        }

        public async Task OnLoadAsync(Player.Player owner)
        {
            AvatarInfo.Values.AsParallel().ForAll(async w => await w.OnLoadAsync(owner)); // hope same avatar with different guid doesnt break anything...
        }

              
        public bool AddAvatar(Avatar avatar, int index = 0)
        {
            if (IsTowerTeam || AvatarInfo.ContainsValue(avatar) || AvatarInfo.Count >= GameServer.Configuration.Server.GameOptions.AvatarLimits.SinglePlayerTeam)
            {
                return false;
            }

            AvatarInfo.Add(index, IsTowerTeam ? avatar.Clone() : avatar);

            //TODO update team resonance and add team openConfigs

            return true;
        }

        public bool RemoveAvatar(int slot)
        {
            if (IsTowerTeam || slot >= AvatarInfo.Count)
            {
                return false;
            }

            AvatarInfo.RemoveAt(slot);
            //TODO update team resonance and remove team openConfigs

            return true;
        }

        public void CopyFrom(TeamInfo team)
        {
            CopyFrom(team, GameServer.Configuration.Server.GameOptions.AvatarLimits.SinglePlayerTeam);
        }

        public bool CopyFrom(TeamInfo team, int maxTeamSize)
        {
            if (IsTowerTeam || team.AvatarInfo.Count > maxTeamSize) return false;
            AvatarInfo = (SortedList<int, Avatar>)team.MemberwiseClone();
            return true;
        }

        public AvatarTeam ToProto(Player.Player player)
        {
            AvatarTeam avatarTeam = new AvatarTeam()
            {
                TeamName = TeamName
            };

            foreach (int id in AvatarInfo.Keys)
            {
                Avatar avatar = player.Avatars.GetAvatarById(id);
                avatarTeam.AvatarGuidList.Add(avatar.Guid);
            }

            return avatarTeam;
        }
    }
}
