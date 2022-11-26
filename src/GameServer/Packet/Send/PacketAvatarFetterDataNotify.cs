using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarFetterDataNotify : BasePacket
    {
        public PacketAvatarFetterDataNotify(Avatar avatar) : base(OpCode.AvatarFightPropNotify)
        {
            AvatarFetterDataNotify proto = new AvatarFetterDataNotify();
            int fetterLevel = avatar.Fetters.FetterLevel;
            AvatarFetterInfo avatarFetter = new AvatarFetterInfo() { ExpLevel = (uint)fetterLevel };

            if (fetterLevel != 10)
            {
                avatarFetter.ExpNumber = (uint)avatar.Fetters.FetterExp;
            }
            else
            {
                avatarFetter.RewardedFetterLevelList.Add(10);
            }
            foreach (FetterData fetter in avatar.Fetters.FetterStates.Values)
            {
                avatarFetter.FetterList.Add(fetter);
            }
            proto.FetterInfoMap.Add(avatar.Guid, avatarFetter);

            Data = proto.ToByteArray();
        }
    }
}
