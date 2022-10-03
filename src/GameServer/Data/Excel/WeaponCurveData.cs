using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("WeaponCurveExcelConfigData.json")]
    internal class WeaponCurveData
    {
        [JsonProperty] public readonly int level;
        [JsonProperty] public readonly CurveInfo[] curveInfos;

		public Tuple<string, float> GetArith(GrowCurveType type)
		{
			foreach (CurveInfo curveInfo in curveInfos)
			{
				if (curveInfo.type == type) return Tuple.Create(curveInfo.arith, curveInfo.value);
			}
			Logger.WriteErrorLine("Could not find value for " + type + " for avatar level:" + level);
			return Tuple.Create("ARITH_MULTI", (float)1.0);
		}

        public static float CalcValue(float value, Tuple<string, float> curve)
        {
            switch (curve.Item1)
            {
                case "ARITH_MULTI":
                    return value * curve.Item2;
                default:
                    Logger.WriteErrorLine("Unknown Weapon curve operation");
                    goto case "ARITH_MULTI";
            }
        }
    }
}
