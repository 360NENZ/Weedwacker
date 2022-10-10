using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class WeaponItem : EquipItem
    {
        [BsonId] public int UniqueId { get; protected set; }
		public List<int>? Affixes { get; protected set; } = new();
		[BsonIgnore] public new int Count { get; protected set; } = 1;
        public int Refinement { get; protected set; } = 0;
		[BsonIgnore] public uint WeaponEntityId;
		public int EquippedAvatar; // By avatarId
		[BsonIgnore] public new WeaponData ItemData;

		public WeaponItem(ulong guid, int itemId, int uniqueId) : base(guid, itemId)
		{
			ItemData = (WeaponData)GameData.ItemDataMap[ItemId];
			Level = 1;

			if (ItemData.skillAffix != null)
			{
				foreach (int skillAffix in ItemData.skillAffix)
				{
					if (skillAffix > 0)
					{
						Affixes.Add(skillAffix);
					}
				}
			}
		}

		public async Task OnLoadAsync(ulong guid)
        {
			ItemData = (WeaponData)GameData.ItemDataMap[ItemId];
			Guid = guid;
			Count = 1;
        }

		public Shared.Network.Proto.Weapon ToWeaponProto()
		{
			Shared.Network.Proto.Weapon weapon = new()
			{
				Level = (uint)Level,
				Exp = (uint)Exp,
				PromoteLevel = (uint)PromoteLevel
			};


			if (Affixes != null && Affixes.Count > 0)
			{
				foreach (int affix in Affixes)
				{
					weapon.AffixMap.Add((uint)affix, (uint)Refinement);
				}
			}

			return weapon;
		}

		public SceneWeaponInfo CreateSceneWeaponInfo()
		{
			SceneWeaponInfo weaponInfo = new SceneWeaponInfo()
			{
				EntityId = WeaponEntityId,
				ItemId = (uint)ItemId,
				Guid = Guid,
				Level = (uint)Level,
				GadgetId = (uint)ItemData.gadgetId,
				AbilityInfo = new AbilitySyncStateInfo() { IsInited = Affixes.Count > 0 }
			};

			if (Affixes.Count > 0)
			{
				foreach (int affix in Affixes)
				{
					weaponInfo.AffixMap.Add((uint)affix, (uint)Refinement);
				}
			}

			return weaponInfo;
		}

		public override Item ToProto()
        {
			Item proto = new()
			{
				Guid = Guid,
				ItemId = (uint)ItemData.id
			};

			Shared.Network.Proto.Weapon weapon = ToWeaponProto();
			proto.Equip = new Equip() { Weapon = weapon, IsLocked = Locked };
			return proto;
		}
    }
}
