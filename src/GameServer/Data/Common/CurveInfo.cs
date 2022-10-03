using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Common
{
	public class CurveInfo
	{
        [JsonProperty]
		public readonly GrowCurveType type;
		[JsonProperty]
		public readonly string arith;
		[JsonProperty]
		public readonly float value;
	}
}
