using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class ReliquaryItem : EquipItem
    {
		public readonly int MainPropId;
		public readonly List<int>? AppendPropIdList = new();
		public int EquipCharacter;
        [BsonIgnore]
		public int WeaponEntityId;
		[BsonIgnore]
		public new readonly ReliquaryData ItemData;

		public ReliquaryItem(int ownerId) : base(ownerId)
        {

        }
		public int GetEquipSlot()
		{
			return (int)ItemData.equipType;
		}
		public Reliquary ToReliquaryProto()
		{
			Reliquary relic = new()
			{
				Level = (uint)Level,
				Exp = (uint)Exp,
				PromoteLevel = (uint)PromoteLevel,
				MainPropId = (uint)MainPropId,
			};
			foreach(int id in AppendPropIdList)
            {
				relic.AppendPropIdList.Add((uint)id);
            }

			return relic;
		}
	}
}
