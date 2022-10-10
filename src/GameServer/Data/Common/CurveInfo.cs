using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Common
{
	[JsonConverter(typeof(StringEnumConverter))]
	public class CurveInfo
	{
        [JsonProperty]
		public readonly GrowCurveType type;
		[JsonProperty]
		public readonly ArithType arith;
		[JsonProperty]
		public readonly float value;
	}
}
