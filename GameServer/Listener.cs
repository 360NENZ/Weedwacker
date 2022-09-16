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
        public const int MaxMessageSize = 16384;
        static readonly byte[] FIRST_RCV_PKT = new byte[] { 0, 0, 0, 255, 0, 0, 0, 0, 0, 0, 0, 0, 73, 150, 2, 210, 255, 255, 255, 255 };
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
            ConnectionLoop();
        }
        static async Task AcceptConnection(UdpReceiveResult rcv)
        {
            if (!FIRST_RCV_PKT.SequenceEqual(rcv.Buffer))
            {
                Logger.WriteErrorLine($"Invalid handshake packet from {rcv.RemoteEndPoint}");
                return;
            }
            Logger.WriteLine($"Received: ({string.Join(", ", rcv.Buffer)}) from: {rcv.RemoteEndPoint}");
            int convId = Connections.GetNextAvailableIndex();
            var convo = Multiplex?.CreateConversation(convId, ConvOpt);
            if (convo == null) return;
            var con = new Connection(convo, rcv.RemoteEndPoint);
            Connections.Add(convId, con);
            var resp = await CreateHandshakeResponse(convId);
            await UDPClient?.SendAsync(resp, resp.Length, rcv.RemoteEndPoint);
        }
        public static async Task<byte[]> CreateHandshakeResponse(int convId)
        {
            await using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);
            bw.Write((byte)0x0);
            bw.Write((byte)0x0);
            bw.Write((byte)0x1);
            bw.Write((byte)0x45);
            bw.Write((byte)0x0);
            bw.Write(convId); // missing 3 bytes yet
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
        static async void ConnectionLoop()
        {
            while (!CancelToken.IsCancellationRequested && Multiplex != null && UDPClient != null)
            {
                await AcceptConnection(await UDPClient.ReceiveAsync());
            }
        }
        
    }
}
