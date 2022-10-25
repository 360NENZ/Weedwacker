using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketGetShopRsp : BasePacket
    {
        public PacketGetShopRsp(Player player, uint shopType) : base(Enums.OpCode.GetShopRsp)
        {
            GetShopRsp proto = new GetShopRsp();

            if (player.ShopManager.HasShop((int)shopType, out Systems.Shop.Shop? shop))
            {
                var shopProto = shop.ToProto();

                proto.Shop = shopProto;
            }
            else
                proto.Retcode = (int)Retcode.RetShopNotOpen; // probably correct retcode
            Data = proto.ToByteArray();
        }
            
    }
}

