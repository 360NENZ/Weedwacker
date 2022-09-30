using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class ReliquaryItem : EquipItem
    {
		public readonly int MainPropId;
		public readonly List<int>? AppendPropIdList = new();
		public int EquippedAvatar; // By avatarId
		[BsonIgnore]
		public new ReliquaryData ItemData { get; protected set; }

		public ReliquaryItem(int guid) : base(guid)
		{
			ItemData = (ReliquaryData)GameData.ItemDataMap[ItemId];
		}

		public async Task OnLoadAsync(long guid)
		{
			ItemData = (ReliquaryData)GameData.ItemDataMap[ItemId];
			Guid = guid;
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

		public SceneReliquaryInfo CreateSceneReliquaryInfo()
		{
			SceneReliquaryInfo relicInfo = new SceneReliquaryInfo()
			{
				ItemId = (uint)ItemId,
				Guid = (ulong)Guid,
				Level = (uint)Level
			};

			return relicInfo;
		}

		public override Item ToProto()
        {
            throw new NotImplementedException();
        }
    }
}
