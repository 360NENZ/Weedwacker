using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Inventory
{
	[BsonDiscriminator(RootClass = true)]
	[BsonKnownTypes(typeof(MaterialItem), typeof(EquipItem))]
	internal abstract class GameItem
    {
        [BsonId]
		private ObjectId id;
		[BsonElement] public int ItemId { get; protected set; }
		public int Count;
		[BsonIgnore] public long Guid; // Player unique id. Generated each session
		[BsonIgnore] public bool IsNew { get; protected set; } = false;
		[BsonIgnore] public ItemData ItemData { get; protected set; }
       

		public GameItem(long guid, int itemId, int count)
		{
			Guid = guid;
			ItemId = itemId;
			ItemData = GameData.ItemDataMap[itemId];
			IsNew = true;
		}

		public abstract Item ToProto();

		public ItemHint ToItemHintProto()
		{
			var hint = new ItemHint() { ItemId = (uint)ItemId, Count = (uint)Count, IsNew = IsNew, Guid = (ulong)Guid };
			if (IsNew) IsNew = false;
			return hint;
		}
	}
}
