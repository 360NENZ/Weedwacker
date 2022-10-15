using MongoDB.Bson.Serialization.Attributes;
using Vim.Math3d;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class TeamManager
    {
        [BsonId] public int OwnerId;
        private Player Owner;
        [BsonDictionaryOptions(MongoDB.Bson.Serialization.Options.DictionaryRepresentation.ArrayOfDocuments)]
        [BsonElement] public SortedList<int, TeamInfo> Teams { get; private set; } = new(); // <index, team>
        [BsonDictionaryOptions(MongoDB.Bson.Serialization.Options.DictionaryRepresentation.ArrayOfDocuments)]
        [BsonElement] public SortedList<int, TeamInfo> TowerTeams { get; private set; } = new(); // Store Abyss teams separately
        [BsonElement] public int CurrentTeamIndex { get; private set; } = 1;
        public int CurrentCharacterIndex = 0; // count from 0
        [BsonIgnore] public List<AvatarEntity> ActiveTeam { get; private set; } = new();
        [BsonIgnore] public TeamInfo MpTeam = new();
        [BsonIgnore] public uint EntityId;

        public TeamManager(Player player)
        {
            Owner = player;
            OwnerId = player.GameUid;
            for (int i = 1; i <= GameServer.Configuration.Server.GameOptions.Constants.DEFAULT_TEAMS; i++)
            {
                Teams.Add(i, new TeamInfo());
            }
        }

        public async Task OnLoadAsync(Player owner)
        {
            Owner = owner;
            // Point to the "real" avatars
            Teams.Values.AsParallel().ForAll(async w => { foreach (var entry in w.AvatarInfo)
                {
                    w.AvatarInfo.Add(entry.Key, owner.Avatars.GetAvatarById(entry.Value.AvatarId));
                }
            });
            // You stay simple clones >:)
            TowerTeams.Values.AsParallel().ForAll(async w => await w.OnLoadAsync(owner));
            foreach (ushort avatar in Teams[CurrentTeamIndex].AvatarInfo.Keys)
                ActiveTeam.Add(new AvatarEntity(Teams[CurrentTeamIndex], avatar));
        }

        /**
         * Search through all teams and if the team matches, return that index.
         * Otherwise, return -1.
         * No match could mean that the team does not currently belong to the player.
         */
        public int GetTeamId(TeamInfo team)
        {
            for (int i = 1; i <= Teams.Count; i++)
            {
                if (Teams[i] == team)
                {
                    return i;
                }
            }
            return -1;
        }

        private bool SetCurrentTeamId(int currentTeamIndex)
        {
            if (Teams.ContainsKey(currentTeamIndex))
            {
                CurrentTeamIndex = currentTeamIndex;
                return true;
            }
            else if(TowerTeams.ContainsKey(currentTeamIndex))
            {
                CurrentTeamIndex = currentTeamIndex;
                return true;
            }
            else return false;
        }
        public ulong GetCurrentCharacterGuid()
        {
            return GetCurrentAvatarEntity().Avatar.Guid;
        }

        public TeamInfo GetCurrentTeamInfo()
        {
            if (Owner.IsInMultiplayer())
                return MpTeam;
            else
                return Teams[CurrentTeamIndex];
        }

        public TeamInfo GetCurrentSinglePlayerTeamInfo() { return Teams[CurrentTeamIndex]; }
        public AvatarEntity GetCurrentAvatarEntity() { return ActiveTeam[CurrentCharacterIndex]; }

        public bool IsSpawned()
        {
            return Owner.Scene != null && Owner.Scene.Entities.ContainsKey(GetCurrentAvatarEntity().Id);
        }

        public int GetMaxTeamSize()
        {
            if (Owner.IsInMultiplayer())
            {
                int max = GameServer.Configuration.Server.GameOptions.AvatarLimits.MultiplayerTeam;
                if (Owner.World.Host == Owner)
                {
                    return Math.Max(1, (int)Math.Ceiling(max / (double)Owner.World.Players.Count));
                }
                return Math.Max(1, (int)Math.Floor(max / (double)Owner.World.Players.Count));
            }
            else
                return GameServer.Configuration.Server.GameOptions.AvatarLimits.SinglePlayerTeam;
        }

        public async Task UpdateTeamEntities()
        {
            // If current team has changed
            AvatarEntity currentEntity = GetCurrentAvatarEntity();
            Dictionary<int, AvatarEntity> existingAvatars = new();
            int prevSelectedAvatarIndex = -1;

            foreach (AvatarEntity entity in ActiveTeam)
            {
                existingAvatars.Add(entity.Avatar.AvatarId, entity);
            }


            // Add back entities into team
            for (int i = 0; i < GetCurrentTeamInfo().AvatarInfo.Count; i++)
            {
                int avatarId = GetCurrentTeamInfo().AvatarInfo[i].AvatarId;
                AvatarEntity entity;

                if (existingAvatars.ContainsKey(avatarId))
                {
                    entity = existingAvatars[avatarId];
                    existingAvatars.Remove(avatarId);
                    if (entity == currentEntity)
                    {
                        prevSelectedAvatarIndex = i;
                    }
                }
                else
                {
                    entity = new AvatarEntity(Owner.Scene, Owner.Avatars.GetAvatarById(avatarId));
                }

                ActiveTeam.Add(entity);
            }

            // Unload removed entities
            foreach (AvatarEntity entity in existingAvatars.Values)
            {
                Owner.Scene.RemoveEntityAsync(entity);
            }

            // Set new selected character index
            if (prevSelectedAvatarIndex == -1)
            {
                // Previous selected avatar is not in the same spot, we will select the current one in the prev slot
                prevSelectedAvatarIndex = Math.Min(CurrentCharacterIndex, ActiveTeam.Count - 1);
            }
            CurrentCharacterIndex = prevSelectedAvatarIndex;

            // Packets
            await Owner.World.BroadcastPacketAsync(new PacketSceneTeamUpdateNotify(Owner));

            // Check if character changed
            if (currentEntity != GetCurrentAvatarEntity())
            {
                // Remove and Add
                await Owner.Scene.ReplaceEntityAsync(currentEntity, GetCurrentAvatarEntity());
            }
        }

        public async Task SetupAvatarTeamAsync(int teamId, List<long> list)
        {
            // Sanity checks
            if (list.Count == 0 || list.Count > GetMaxTeamSize() || Owner.IsInMultiplayer())
            {
                return;
            }

            // Get team
            if (!Teams.TryGetValue(teamId, out TeamInfo teamInfo)) return;
           
            // Set team data
            HashSet<Avatar.Avatar> newTeamAvatars = new();
            foreach (ulong guid in list)
            {
                Avatar.Avatar? avatar = Owner.Avatars.GetAvatarByGuid(guid);
                if (avatar == null || newTeamAvatars.Contains(avatar))
                {
                    // Should never happen
                    return;
                }
                newTeamAvatars.Add(avatar);
            }

            // Replace the old team with the new one
            teamInfo = new TeamInfo(newTeamAvatars, teamInfo.TeamName, teamInfo.IsTowerTeam);
            await Owner.SendPacketAsync(new PacketAvatarTeamUpdateNotify(Owner));
        }

        public async Task SetupMpTeamAsync(List<ulong> list)
        {
            // Sanity checks
            if (list.Count == 0 || list.Count > GetMaxTeamSize() || Owner.IsInMultiplayer())
            {
                return;
            }

            // Set team data
            HashSet<Avatar.Avatar> newTeam = new();
            foreach (ulong aLong in list)
            {
                Avatar.Avatar? avatar = Owner.Avatars.GetAvatarByGuid(aLong);
                if (avatar == null || newTeam.Contains(avatar))
                {
                    // Should never happen
                    return;
                }
                newTeam.Add(avatar);
            }

            // Replace the old MpTeam with the new one
            MpTeam = new TeamInfo(newTeam, MpTeam.TeamName, false);
        }
        public bool SetTeamName(int teamId, string teamName)
        {
            if (Teams.TryGetValue(teamId, out TeamInfo teamInfo))
            {
                return false;
            }
            else
            {
                teamInfo.TeamName = teamName;
                return true;
            }
        }

        public async Task ChangeAvatar(ulong guid)
        {
            AvatarEntity oldEntity = GetCurrentAvatarEntity();

            if (guid == oldEntity.Avatar.Guid)
            {
                return;
            }

            AvatarEntity newEntity = null;
            int index = -1;
            for (int i = 0; i < ActiveTeam.Count; i++)
            {
                if (guid == ActiveTeam.ElementAt(i).Avatar.Guid)
                {
                    index = i;
                    newEntity = ActiveTeam.ElementAt(i);
                }
            }

            if (index < 0 || newEntity == oldEntity)
            {
                return;
            }

            // Set index
            CurrentCharacterIndex = index;

            // Old entity motion state
            oldEntity.SetMotionState(MotionState.Standby);

            // Remove and Add
            await Owner.Scene.ReplaceEntityAsync(oldEntity, newEntity);
        }

        public async Task OnAvatarDie(ulong dieGuid, PlayerDieType dieType)
        {
            AvatarEntity deadAvatar = GetCurrentAvatarEntity();

            if (deadAvatar.LiveState == LifeState.LIFE_ALIVE || deadAvatar.Avatar.Guid != dieGuid)
            {
                return;
            }

            uint killedBy = deadAvatar.KilledBy;

            if (dieType == PlayerDieType.Drawn)
            {
                //TODO
            }
            else
            {
                // Replacement avatar
                AvatarEntity replacement = null;
                int replaceIndex = -1;

                for (int i = 0; i < ActiveTeam.Count; i++)
                {
                    AvatarEntity entity = ActiveTeam[i];
                    if (entity.LiveState == LifeState.LIFE_ALIVE)
                    {
                        replaceIndex = i;
                        replacement = entity;
                        break;
                    }
                }

                if (replacement == null)
                {
                    // No more living team members...
                    await Owner.SendPacketAsync(new PacketWorldPlayerDieNotify(deadAvatar.Id, dieType, killedBy));
                }
                else
                {
                    // Set index and spawn replacement member
                    CurrentCharacterIndex = replaceIndex;
                    await Owner.Scene.AddEntityAsync(replacement);
                }
            }
        }

        public async Task<bool> ReviveAvatarAsync(Avatar.Avatar avatar)
        {
            foreach (AvatarEntity entity in ActiveTeam)
            {
                if (entity.Avatar == avatar)
                {
                    if (entity.LiveState == LifeState.LIFE_ALIVE)
                    {
                        return false;
                    }

                    entity.FightProps[
                        FightProperty.FIGHT_PROP_CUR_HP] =
                        entity.FightProps[FightProperty.FIGHT_PROP_MAX_HP] * .1f;
                    await Owner.SendPacketAsync(new PacketAvatarFightPropUpdateNotify(entity.Avatar, FightProperty.FIGHT_PROP_CUR_HP));
                    await Owner.SendPacketAsync(new PacketAvatarLifeStateChangeNotify(entity.Avatar));
                    return true;
                }
            }

            return false;
        }

        public async Task<bool> HealAvatar(Avatar.Avatar avatar, int healRate, int healAmount)
        {
            foreach (AvatarEntity entity in ActiveTeam)
            {
                if (entity.Avatar == avatar)
                {
                    if (!(entity.LiveState == LifeState.LIFE_ALIVE))
                    {
                        return false;
                    }

                    entity.FightProps[
                        FightProperty.FIGHT_PROP_CUR_HP] =
                        (float)Math.Min(
                            entity.FightProps[FightProperty.FIGHT_PROP_CUR_HP] +
                                entity.FightProps[FightProperty.FIGHT_PROP_MAX_HP] * healRate / 100.0 +
                                healAmount / 100.0,
                            entity.FightProps[FightProperty.FIGHT_PROP_MAX_HP]);
                    await Owner.SendPacketAsync(new PacketAvatarFightPropUpdateNotify(entity.Avatar, FightProperty.FIGHT_PROP_CUR_HP));
                    await Owner.SendPacketAsync(new PacketAvatarLifeStateChangeNotify(entity.Avatar));
                    return true;
                }
            }
            return false;
        }
    }
}
