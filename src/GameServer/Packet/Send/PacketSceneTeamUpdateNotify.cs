using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSceneTeamUpdateNotify : BasePacket
    {
		public PacketSceneTeamUpdateNotify(Player player) : base(Enums.OpCode.SceneTeamUpdateNotify)
		{
			SceneTeamUpdateNotify proto = new SceneTeamUpdateNotify()
			{
				IsInMp = player.IsInMultiplayer()
			};

			foreach (Player p in player.World.Players)
			{
				foreach (AvatarEntity avatar in p.TeamManager.ActiveTeam)
                {
                    //TODO
                    AbilitySyncStateInfo avatarAbilityInfo = new();
					//TODO
                    AbilitySyncStateInfo weaponAbilityInfo = new();
					//TODO
					ServerBuff buffList = new();

					SceneTeamAvatar avatarProto = new()
					{
						PlayerUid = (uint)p.GameUid,
						AvatarGuid = avatar.Avatar.Guid,
						EntityId = avatar.Id,
						SceneId = (uint)p.SceneId,
						SceneEntityInfo = avatar.ToProto(),
						WeaponGuid = avatar.Avatar.GetWeapon().Guid,
						WeaponEntityId = avatar.Avatar.GetWeapon().WeaponEntityId,
						IsPlayerCurAvatar = p.TeamManager.GetCurrentAvatarEntity() == avatar,
						IsOnScene = p.TeamManager.GetCurrentAvatarEntity() == avatar, // might affect cutscenes. investigate
						AvatarAbilityInfo = avatarAbilityInfo,
						WeaponAbilityInfo = weaponAbilityInfo,
						AbilityControlBlock = avatar.GetAbilityControlBlock(),
						IsReconnect = false, //TODO
					};


					if (player.IsInMultiplayer())
					{
						avatarProto.AvatarInfo = avatar.Avatar.ToProto();
						avatarProto.SceneAvatarInfo = avatar.GetSceneAvatarInfo(); // why mihoyo...
					}

					proto.SceneTeamAvatarList.Add(avatarProto);
				}
			}

			Data = proto.ToByteArray();
		}
	}
}
