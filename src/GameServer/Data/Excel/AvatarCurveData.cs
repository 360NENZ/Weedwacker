using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data
{
	[Resource("AvatarCurveExcelConfigData.json")]
	public class AvatarCurveData : GameResource
	{
		[JsonProperty]
		public readonly int level;
		[JsonProperty]
		public readonly CurveInfo[] curveInfos;
}