using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Packet
{
    internal class BasePacket
    {
        const ushort Magic1 = 0x4567;
        const ushort Magic2 = 0x89ab;

        public ushort Opcode { get; protected set; }
        public bool ShouldBuildHeader { get; protected set; } = false;

        private byte[] Header = Array.Empty<byte>();
        public byte[] Data { get; protected set; } = Array.Empty<byte>();

        // Encryption
        protected bool UseDispatchKey;
        protected bool ShouldEncrypt = true;

        public BasePacket(OpCode opcode)
        {
            Opcode = (ushort)opcode;
        }

        public BasePacket(OpCode opcode, uint clientSequence)
        {
            Opcode = (ushort)opcode;
            BuildHeader(clientSequence);
        }

        public BasePacket(OpCode opcode, bool buildHeader)
        {
            Opcode = (ushort)opcode;
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
