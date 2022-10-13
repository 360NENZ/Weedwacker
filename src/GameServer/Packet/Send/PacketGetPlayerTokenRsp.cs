using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketGetPlayerTokenRsp : BasePacket
    {
        public PacketGetPlayerTokenRsp(Connection session, string token): base(OpCode.GetPlayerTokenRsp, true, true)
        {

            GetPlayerTokenRsp p = new GetPlayerTokenRsp()
            {
                Uid = (uint)session.Player.GameUid,
                Token = token,
                AccountType = 1,
                IsProficientPlayer = session.Player.Profile.HeroName != "", // Not sure what this checks
                SecretKeySeed = Crypto.ENCRYPT_SEED,
                SecurityCmdBuffer = ByteString.CopyFrom(Crypto.ENCRYPT_SEED_BUFFER),
                PlatformType = 3,
                ChannelId = 1,
                CountryCode = "US",
                ClientVersionRandomKey = "c25-314dd05b0b5f",
                RegPlatform = 3,
                ClientIpStr = GameServer.Configuration.Server.AccessAddress
            };
            Data = p.ToByteArray();
        }

        public PacketGetPlayerTokenRsp(Connection session, int retcode, string msg, int blackEndTime) : base(OpCode.GetPlayerTokenRsp, true, true)
        {

            GetPlayerTokenRsp p = new GetPlayerTokenRsp()
            {
                AccountType = 1,
                IsProficientPlayer = session.Player.Profile.HeroName != "", // Not sure what this checks
                Retcode = retcode,
                Msg = msg,
                BlackUidEndTime = (uint)blackEndTime,
                RegPlatform = 3,
                CountryCode = "US",
                ClientIpStr = GameServer.Configuration.Server.AccessAddress
            };
            Data = p.ToByteArray();
        }

        public PacketGetPlayerTokenRsp(Connection session, string encryptedSeed, string encryptedSeedSign, string token) : base(OpCode.GetPlayerTokenRsp, true, true)
        {

            GetPlayerTokenRsp p = new GetPlayerTokenRsp()
            {
                Uid = (uint)session.Player.GameUid,
                Token = token,
                AccountType = 1,
                IsProficientPlayer = session.Player.Profile.HeroName != "", // Not sure what this checks
                SecretKeySeed = Crypto.ENCRYPT_SEED,
                //SecurityCmdBuffer = ByteString.CopyFrom(Crypto.ENCRYPT_SEED_BUFFER),
                PlatformType = 3,
                ChannelId = 1,
                CountryCode = "US",
                //ClientVersionRandomKey = "c25-314dd05b0b5f",
                RegPlatform = 3,
                ClientIpStr = GameServer.Configuration.Server.AccessAddress,
                EncryptedSeed = encryptedSeed,
                SeedSignature = encryptedSeedSign
            };

            Data = p.ToByteArray();
        }
    }
}
