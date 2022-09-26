using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data.Excel;

namespace Weedwacker.GameServer.Systems.Inventory
{
	[BsonDiscriminator(RootClass = true)]
	[BsonKnownTypes(typeof(MaterialItem), typeof(EquipItem))]
	internal class GameItem
    {
        [BsonId]
		private readonly ObjectId id;
		public readonly int OwnerId;
		public readonly int ItemId;
        [BsonIgnore]
		public readonly long Guid; // Player unique id. Generated each session
		[BsonIgnore]
		public ItemData ItemData;

		public GameItem(int ownerId)
		{
			OwnerId = ownerId;
		}
	}
}
