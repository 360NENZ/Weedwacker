using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPlayerDataNotify : BasePacket
    {
		public PacketPlayerDataNotify(Player player) : base(Enums.OpCode.PlayerDataNotify, 2)
		{
			PlayerDataNotify p = new PlayerDataNotify()
			{
				NickName = player.Profile.Nickname,
				ServerTime = (ulong)DateTimeOffset.Now.ToUnixTimeMilliseconds(),
				IsFirstLoginToday = true, //TODO
				RegionId = (uint)player.RegionId
			};

			foreach (var prop in player.PlayerProperties)
			{
				p.PropMap.Add((uint)prop.Key, new PropValue() { Type = (uint)prop.Key, Ival = prop.Value, Val = (uint)prop.Value});
			}

			Data = p.ToByteArray();
		}
	}
}