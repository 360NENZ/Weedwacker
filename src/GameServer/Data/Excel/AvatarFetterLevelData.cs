using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
	[Resource("AvatarFettersLevelExcelConfigData.json")]
	public class AvatarFetterLevelData
	{
        [JsonProperty]
		public readonly int fetterLevel;
		[JsonProperty]
		public readonly int needExp;
	}
}
