using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.BornTypes
{
    internal class ConfigBornByAttachPoint : BaseBornType
	{
		[JsonProperty] public readonly string attachPointName;
    }
}
