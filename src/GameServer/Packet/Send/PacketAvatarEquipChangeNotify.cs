using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarEquipChangeNotify : BasePacket
    {
		public PacketAvatarEquipChangeNotify(Avatar avatar, EquipItem item, EquipType slot) : base(OpCode.AvatarEquipChangeNotify)
		{

			AvatarEquipChangeNotify proto = new()
			{
				AvatarGuid = (ulong)avatar.Guid,
				EquipType = (uint)slot,
				EquipGuid = (ulong)item.Guid,
				ItemId = (uint)item.ItemId
			};

			if (item.ItemData.itemType == ItemType.ITEM_WEAPON)
			{
				var asWeapon = (WeaponItem)item;
				proto.Weapon = asWeapon.CreateSceneWeaponInfo();
			}
			else
			{
				var asRelic = (ReliquaryItem)item;
				proto.Reliquary = asRelic.CreateSceneReliquaryInfo();
			}

			Data = proto.ToByteArray();
		}

		public PacketAvatarEquipChangeNotify(Avatar avatar, EquipType slot) : base(OpCode.AvatarEquipChangeNotify)
		{
			AvatarEquipChangeNotify proto = new()
			{
				AvatarGuid = (ulong)avatar.Guid,
				EquipType = (uint)slot
			};

			Data = proto.ToByteArray();
		}
	}
}
