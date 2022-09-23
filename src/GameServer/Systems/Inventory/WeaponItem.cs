
using Weedwacker.GameServer.Data.Excel;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class WeaponItem : EquipItem
    {
        public List<int>? Affixes { get; protected set; } 
        public int Refinement { get; protected set; } = 0;
		public new readonly WeaponData ItemData;

		public WeaponItem(int ownerId) : base(ownerId)
		{ 
			
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
	}
}
