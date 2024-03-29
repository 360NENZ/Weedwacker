﻿using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarSkillInfoNotify : BasePacket
    {
        public PacketAvatarSkillInfoNotify(ulong avatarGuid, IDictionary<int, int> skillExtraChargeMap) : base(Enums.OpCode.AvatarSkillInfoNotify)
        {
            var proto = new AvatarSkillInfoNotify()
            {
                Guid = avatarGuid
            };

            skillExtraChargeMap.AsParallel().ForAll(w => proto.SkillMap.Add((uint)w.Key, new AvatarSkillInfo() { MaxChargeCount = (uint)w.Value }));

            Data = proto.ToByteArray();
        }
    }
}
