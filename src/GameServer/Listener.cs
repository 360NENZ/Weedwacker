using KcpSharp;
using Microsoft.VisualBasic;
using System.Buffers;
using System.Net;
using System.Net.Sockets;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer
{
    internal class Listener
    {
        public const int MAX_MSG_SIZE = 16384;
        public const int HANDSHAKE_SIZE = 20;
        static Socket? UDPListener => UDPClient?.Client;
        static UdpClient? UDPClient;
        static IPEndPoint? ListenAddress;
        static IKcpTransport<IKcpMultiplexConnection>? KCPTransport;
        static readonly CancellationTokenSource CancelToken = new CancellationTokenSource();
        static IKcpMultiplexConnection? Multiplex => KCPTransport?.Connection;
        public static readonly SortedList<long, Connection> Connections = new();
        public static Connection? GetConnectionByEndPoint(IPEndPoint ep) => Connections.Values.FirstOrDefault(c => c.RemoteEndPoint.Equals(ep));
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
        private static readonly int PORT = GameServer.Configuration.Server.AccessPort;
        public static void StartListener()
        {
            ListenAddress = new(IPAddress.Parse(GameServer.Configuration.Server.AccessAddress), PORT);
            UDPClient = new(ListenAddress);        
            if (UDPListener == null) return;
            KCPTransport = KcpSocketTransport.CreateMultiplexConnection(UDPClient, 1400);
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
            var convId = con.ConversationID.Value;
            if (Connections.Remove(convId))
            {
                Multiplex?.UnregisterConversation(convId);
                Logger.WriteLine($"Connection with {con.RemoteEndPoint} has been closed");
            }
        }
        public static async Task HandleHandshake(UdpReceiveResult rcv)
        {
            try
            {
                var con = GetConnectionByEndPoint(rcv.RemoteEndPoint);
                await using var ms = new MemoryStream(rcv.Buffer);
                using var br = new BinaryReader(ms);
                int code = br.ReadInt32BE();
                br.ReadUInt32();
                br.ReadUInt32();
                int enet = br.ReadInt32BE();
                br.ReadUInt32();
                switch (code)
                {
                    case 0x000000FF:
                        if (con != null)
                        {
                            Logger.WriteLine($"Duplicate handshake from {con.RemoteEndPoint}");
                            return;
                        }
                        await AcceptConnection(rcv, enet);
                        break;
                    case 0x00000194:
                        if (con == null)
                        {
                            Logger.WriteLine($"Inexistent connection asked for disconnect from {rcv.RemoteEndPoint}");
                            return;
                        }
                        await SendDisconnectPacket(con, 5);
                        break;
                    default:
                        Logger.WriteErrorLine($"Invalid handshake code received {code}");
                        return;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorLine($"Failed to handle handshake: {ex}");
            }
        }
        static async Task AcceptConnection(UdpReceiveResult rcv, int enet)
        {
            var convId = Connections.GetNextAvailableIndex();
            var convo = Multiplex?.CreateConversation(convId, rcv.RemoteEndPoint, ConvOpt);
            if (convo == null) return;
            var con = new Connection(convo, rcv.RemoteEndPoint);
            RegisterConnection(con);
            await SendHandshakeResponse(con, enet);
        }
        static async Task SendHandshakeResponse(Connection user, int enet)
        {
            if (user == null || UDPClient == null || !user.ConversationID.HasValue) return;
            long convId = user.ConversationID.Value;
            await using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);
            bw.WriteInt32BE(0x00000145);
            bw.WriteConvID(convId);
            bw.WriteInt32BE(enet);
            bw.WriteInt32BE(0x14514545);
            var data = ms.ToArray();
            await UDPClient.SendAsync(data, data.Length, user.RemoteEndPoint);
        }
        public static async Task SendDisconnectPacket(Connection user, int code)
        {
            if (user == null || UDPClient == null || !user.ConversationID.HasValue) return;
            long convId = user.ConversationID.Value;
            await using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);
            bw.WriteInt32BE(0x00000194);
            bw.WriteConvID(convId);
            bw.WriteInt32BE(code);
            bw.WriteInt32BE(0x19419494);
            var data = ms.ToArray();
            await UDPClient.SendAsync(data, data.Length, user.RemoteEndPoint);
        }
    }
}
