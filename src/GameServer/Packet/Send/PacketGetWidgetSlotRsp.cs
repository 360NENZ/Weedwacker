using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketGetWidgetSlotRsp : BasePacket
    {
        public PacketGetWidgetSlotRsp(Player player) : base(Enums.OpCode.GetWidgetSlotRsp)
        {
            //TODO
            GetWidgetSlotRsp proto =new();

            if (player.WidgetId == 0)
            {  
                proto.SlotList.Add(new WidgetSlotData() { Tag = WidgetSlotTag.AttachAvatar});
            }
            else
            {
                proto.SlotList.Add(
                        new WidgetSlotData()
                        { 
                            IsActive = true,
                            MaterialId = (uint)player.WidgetId,
                            /*
                            CdOverTime = ,
                            Tag =,
                            */
                        });

                proto.SlotList.Add(
                        new WidgetSlotData()
                        { 
                            Tag = WidgetSlotTag.AttachAvatar
                        });
            }

            Data = proto.ToByteArray();
        }
    }
}
