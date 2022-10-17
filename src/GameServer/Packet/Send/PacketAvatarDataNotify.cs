using Google.Protobuf;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarDataNotify : BasePacket
    {
        public PacketAvatarDataNotify(Player player) : base(Enums.OpCode.AvatarDataNotify, true)
        {
            AvatarDataNotify proto = new AvatarDataNotify()
            {
                CurAvatarTeamId = (uint)player.TeamManager.CurrentTeamIndex,
            };
            (player.Inventory.SubInventories[Enums.ItemType.ITEM_MATERIAL] as MaterialSubInv).FlyCloakList.AsParallel().ForAll(w => proto.OwnedFlycloakList.Add((uint)w));
            (player.Inventory.SubInventories[Enums.ItemType.ITEM_MATERIAL] as MaterialSubInv).CostumeList.AsParallel().ForAll(w => proto.OwnedCostumeList.Add((uint)w));

            player.Avatars.Avatars.Values.AsParallel().ForAll(w => proto.AvatarList.Add(w.ToProto()));

            foreach (var entry in player.TeamManager.Teams)
            {
                // check if not all slots are empty
                if (entry.Value.AvatarInfo.Keys.Distinct().Count() >= 1)
                {
                    TeamInfo teamInfo = entry.Value;
                    proto.AvatarTeamMap.Add((uint)entry.Key, teamInfo.ToProto(player));
                }
                else
                    proto.AvatarTeamMap.Add((uint)entry.Key, new AvatarTeam());
            }

            // Set main character
            Avatar? mainCharacter = player.Avatars.GetAvatarById(player.MainCharacterId);
            if (mainCharacter != null)
            {
                proto.ChooseAvatarGuid = mainCharacter.Guid;
            }

            Data = proto.ToByteArray();
        }
    }
}
