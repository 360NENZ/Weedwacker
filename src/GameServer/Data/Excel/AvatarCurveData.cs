using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data
{
	[Resource("AvatarCurveExcelConfigData.json")]
	public class AvatarCurveData : GameResource
	{
		[JsonProperty]
		public readonly int level;
		[JsonProperty]
		public readonly CurveInfo[] curveInfos;

		public double GetMultiplier(string type)
		{
			foreach (CurveInfo curveInfo in curveInfos)
			{
				if (curveInfo.type == type) return curveInfo.value;
			}
			Logger.WriteErrorLine("Could not find value for " + type + " for avatar level:" + level);
			return 1;
		}
	}
}