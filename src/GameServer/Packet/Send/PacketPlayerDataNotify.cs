using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPlayerDataNotify : BasePacket
    {
        public PacketPlayerDataNotify(Player player) : base(OpCode.PlayerDataNotify, 2)
        {
            PlayerDataNotify p = new PlayerDataNotify()
            {
                NickName = player.Profile.Nickname,
                ServerTime = (ulong)DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                IsFirstLoginToday = true, //TODO
                RegionId = (uint)player.RegionId
            };

            foreach (PlayerProperty prop in Enum.GetValues(typeof(PlayerProperty)))
            {
                if ((int)prop >= 10000)
                    p.PropMap.Add((uint)prop, new PropValue() { Type = (uint)prop, Ival = player.PlayerProperties.GetValueOrDefault(prop), Val = (uint)player.PlayerProperties.GetValueOrDefault(prop) });
            }

            Data = p.ToByteArray();
        }
    }
}