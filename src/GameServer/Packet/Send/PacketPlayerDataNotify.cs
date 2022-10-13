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

			player.PlayerProperties.AsParallel().ForAll(w => {
				p.PropMap.Add((uint)w.Key, new PropValue() { Type = (uint)w.Key, Ival = w.Value, Val = (uint)w.Value});
			});

			Data = p.ToByteArray();
		}
	}
}