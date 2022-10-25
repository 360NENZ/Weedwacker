using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAllWidgetDataNotify : BasePacket
    {
        //TODO
        public PacketAllWidgetDataNotify(Player player) : base(OpCode.AllWidgetDataNotify)
        {
            AllWidgetDataNotify p = new()
            {
                LunchBoxData = new(),
            };
            p.SlotList.Add(new WidgetSlotData() { Tag = WidgetSlotTag.AttachAvatar });

            Data = p.ToByteArray();
        }
    }
}
