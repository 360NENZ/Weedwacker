using KcpSharp;
using Microsoft.VisualBasic;
using System.Buffers;
using System.Net;
using System.Net.Sockets;
using Weedwacker.Shared.Utils;

namespace GameServer
{
    internal class Listener
    {
        public const int MAX_MSG_SIZE = 16384;
        static readonly byte[] FIRST_RCV_PKT = new byte[] { 0, 0, 0, 255, 0, 0, 0, 0, 0, 0, 0, 0, 73, 150, 2, 210, 255, 255, 255, 255 };
        public const int HANDSHAKE_SIZE = 20;
        public static bool IsHandShake(params byte[] data) => FIRST_RCV_PKT.SequenceEqual(data);
        static Socket? UDPListener => UDPClient?.Client;
        static UdpClient? UDPClient;
        static IPEndPoint? ListenAddress;
        static IKcpTransport<IKcpMultiplexConnection>? KCPTransport;
        static readonly CancellationTokenSource CancelToken = new CancellationTokenSource();
        static IKcpMultiplexConnection? Multiplex => KCPTransport?.Connection;
        static readonly SortedList<int, Connection> Connections = new();
        static readonly KcpConversationOptions ConvOpt = new()
        {
            StreamMode = false,
            Mtu = 1400,
            ReceiveWindow = 256,
            SendWindow = 256,
            NoDelay = true,
            UpdateInterval = 100,
            KeepAliveOptions = new(1000, 30000)
        };
        const int PORT = 22102;
        public static void StartListener()
        {
            ListenAddress = new(IPAddress.Any, PORT);
            UDPClient = new(ListenAddress);        
            if (UDPListener == null) return;
            KCPTransport = KcpSocketTransport.CreateMultiplexConnection(UDPListener, ListenAddress, 1400);
            KCPTransport.Start();
        }
        static void RegisterConnection(Connection con)
        {
            if (!con.ConversationID.HasValue) return;
            Connections[con.ConversationID.Value] = con;
        }
        public static void UnregisterConnection(Connection con)
        {
            if (!con.ConversationID.HasValue) return;
            if (Connections.Remove(con.ConversationID.Value))
                Logger.WriteLine($"Connection with {con.RemoteEndPoint} has been closed");
        }
        public static async Task AcceptConnection(SocketReceiveFromResult rcv)
        {
            int convId = Connections.GetNextAvailableIndex();
            var convo = Multiplex?.CreateRawChannel(convId);
            if (convo == null) return;
            var user = (IPEndPoint)rcv.RemoteEndPoint;
            var con = new Connection(convo, user);
            RegisterConnection(con);
            var resp = await CreateHandshakeResponse(convId);
            if (UDPClient == null) return;
            await UDPClient.SendAsync(resp, resp.Length, user);
        }
        public static async Task<byte[]> CreateHandshakeResponse(int convId)
        {
            await using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);
            bw.Write((byte)0x0);
            bw.Write((byte)0x0);
            bw.Write((byte)0x1);
            bw.Write((byte)0x45);
            bw.Write((ulong)convId);
            bw.Write((byte)0x49);
            bw.Write((byte)0x96);
            bw.Write((byte)0x02);
            bw.Write((byte)0xd2);
            bw.Write((byte)0x14);
            bw.Write((byte)0x51);
            bw.Write((byte)0x45);
            bw.Write((byte)0x45);
            return ms.ToArray();
        }
    }
}
