using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Packets
{
    internal class BasePacket
    {
        private static readonly ushort Magic1 = 0x4567;
        private static readonly ushort Magic2 = 0x89ab;

        public ushort Opcode { get; private set; }
        public bool ShouldBuildHeader { get; private set; } = false;

        private byte[] Header = Array.Empty<byte>();
        public byte[] Data { get; private set; } = Array.Empty<byte>();

        // Encryption
        private readonly bool UseDispatchKey;
        public bool ShouldEncrypt = true;

        public BasePacket(ushort opcode)
        {
            Opcode = opcode;
        }

        public BasePacket(ushort opcode, uint clientSequence)
        {
            Opcode = opcode;
            BuildHeader(clientSequence);
        }

        public BasePacket(ushort opcode, bool buildHeader)
        {
            Opcode = opcode;
            ShouldBuildHeader = buildHeader;
        }

        public BasePacket(ushort opcode, bool buildHeader, bool useDispatchKey)
        {
            Opcode = opcode;
            ShouldBuildHeader = buildHeader;
            UseDispatchKey = useDispatchKey;
        }

        public BasePacket BuildHeader(uint clientSequence)
        {
            if (clientSequence == 0)
            {
                return this;
            }
            var header = new PacketHead
            {
                ClientSequenceId = clientSequence,
                SentMs = (ulong)DateTimeOffset.Now.ToUnixTimeMilliseconds()
            };
            
            Header = header.ToByteArray();
            return this;
        }

        public async Task<byte[]> BuildPacketAsync()
        {
            await using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);

            bw.Write(Magic1);
            bw.Write(Opcode);
            bw.Write((ushort)Header.Length);
            bw.Write(Data.Length);
            bw.Write(Header);
            bw.Write(Data);
            bw.Write(Magic2);

            byte[] packet = ms.ToArray();

            if (ShouldEncrypt)
            {
                Crypto.Xor(packet, UseDispatchKey ? Crypto.DISPATCH_KEY : Crypto.ENCRYPT_KEY);
            }

            return packet;
        }
    }
}
