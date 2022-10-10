using MongoDB.Bson.Serialization.Attributes;

namespace Weedwacker.GameServer.Systems.Inventory
{
	[BsonKnownTypes(typeof(WeaponItem), typeof(ReliquaryItem))]
	internal abstract class EquipItem : GameItem
    {
        // Equips
        public int Level { get; protected set; }
		public int Exp { get; protected set; }
		public int TotalExp { get; protected set; }
		public int PromoteLevel { get; protected set; }
		public bool Locked { get; protected set; }
		public int EquippedAvatar = 0;

		protected EquipItem(ulong guid, int itemId) : base(guid, itemId, 1)
		{
		}
		public static int GetMinPromoteLevel(int level)
		{
			if (level > 80)
			{
				return 6;
			}
			else if (level > 70)
			{
				return 5;
			}
			else if (level > 60)
			{
				return 4;
			}
			else if (level > 50)
			{
				return 3;
			}
			else if (level > 40)
			{
				return 2;
			}
			else if (level > 20)
			{
				return 1;
			}
			return 0;
		}
	}
}
