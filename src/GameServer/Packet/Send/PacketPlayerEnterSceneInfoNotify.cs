﻿using Google.Protobuf;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPlayerEnterSceneInfoNotify : BasePacket
    {
        public PacketPlayerEnterSceneInfoNotify(Player player) : base(Enums.OpCode.PlayerEnterSceneInfoNotify)
        {
            PlayerEnterSceneInfoNotify proto = new PlayerEnterSceneInfoNotify()
            {
                CurAvatarEntityId = player.TeamManager.GetCurrentAvatarEntity().EntityId,
                EnterSceneToken = player.EnterSceneToken
            };

            proto.TeamEnterInfo = new TeamEnterSceneInfo()
            {
                TeamEntityId = player.TeamManager.EntityId,
                TeamAbilityInfo = new(), //player.TeamManager.AbilitySyncState,
                AbilityControlBlock = new() //TODO
            };

            proto.MpLevelEntityInfo = new MPLevelEntityInfo()
            {
                AuthorityPeerId = player.World.GetHostPeerId(),
                AbilityInfo = new(), //TODO
                EntityId = player.World.LevelEntityId
            };

            foreach (AvatarEntity avatar in player.TeamManager.ActiveTeam.Values)
            {
                WeaponItem weapon = avatar.Avatar.GetWeapon();

                AvatarEnterSceneInfo avatarInfo = new AvatarEnterSceneInfo()
                {
                    AvatarGuid = avatar.Avatar.Guid,
                    AvatarEntityId = avatar.EntityId,
                    WeaponGuid = weapon.Guid,
                    WeaponEntityId = weapon.WeaponEntityId,
                    AvatarAbilityInfo = new(), //TODO
                    WeaponAbilityInfo = new() //TODO
                };

                proto.AvatarEnterInfo.Add(avatarInfo);
            }

            Data = proto.ToByteArray();
        }
    }
}
