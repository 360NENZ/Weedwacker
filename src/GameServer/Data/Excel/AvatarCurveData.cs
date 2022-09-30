using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data
{
	[Resource("AvatarCurveExcelConfigData.json")]
	public class AvatarCurveData
	{ 
		[JsonProperty]
		public readonly int level;
		[JsonProperty]
		public readonly CurveInfo[] curveInfos;

		public Tuple<string,float> GetArith(string type)
		{
			foreach (CurveInfo curveInfo in curveInfos)
			{
				if (curveInfo.type == type) return Tuple.Create(curveInfo.type,curveInfo.value);
			}
			Logger.WriteErrorLine("Could not find value for " + type + " for avatar level:" + level);
			return Tuple.Create("ARITH_MULTI",(float)1.0);
		}
	}
}