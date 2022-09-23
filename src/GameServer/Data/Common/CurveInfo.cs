using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common
{
	public class CurveInfo
	{
        [JsonProperty]
		public readonly string type;
		[JsonProperty]
		public readonly string arith;
		[JsonProperty]
		public readonly float value;
	}
}
