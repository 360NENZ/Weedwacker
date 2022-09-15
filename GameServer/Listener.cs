using KcpSharp;
using System.Buffers;
using System.Net;
using System.Net.Sockets;
namespace GameServer
{
    internal class Listener
    {
        const int MaxMessageSize = 16384;
        static Socket? UDPListener => UDPClient?.Client;
        static UdpClient? UDPClient;
        static IPEndPoint? ListenAddress;
        static IKcpTransport<KcpConversation>? KCPTransport;
        static CancellationToken CancelToken;
        static KcpConversation? Conversation => KCPTransport?.Connection;
        public static void StartListener()
        {
            int port = 22102;
            int keepAliveInterval = 1000;
            int keepAliveTimeout = 30000;
            UDPClient = new(port);
            ListenAddress = new(IPAddress.Any, port);
            if (UDPListener == null) return;
            KCPTransport = KcpSocketTransport.CreateConversation(UDPListener, ListenAddress, new() { 
                StreamMode = false,
                Mtu = 1400,
                ReceiveWindow = 256,
                SendWindow = 256,
                NoDelay = true,
                UpdateInterval = 100,
                KeepAliveOptions = new(keepAliveInterval, keepAliveTimeout)
            });
            KCPTransport.Start();
            ReceiveLoop();
        }
        static async void ReceiveLoop()
        {
            CancelToken = new CancellationTokenSource().Token;
            while (!CancelToken.IsCancellationRequested && Conversation != null)
            {
                // WaitToReceiveAsync call completes when there is at least one message is received or the transport is closed.
                KcpConversationReceiveResult result = await Conversation.WaitToReceiveAsync(CancelToken);
                if (result.TransportClosed)
                {
                    break;
                }
                if (result.BytesReceived > MaxMessageSize)
                {
                    // The message is too large.
                    Conversation.SetTransportClosed();
                    break;
                }

                byte[] buffer = ArrayPool<byte>.Shared.Rent(result.BytesReceived);
                try
                {
                    // TryReceive should not return false here, unless the transport is closed.
                    // So we don't need to check for result.TransportClosed.
                    if (!Conversation.TryReceive(buffer, out result))
                    {
                        break;
                    }
                    ProcessMessageAsync(buffer.AsMemory(0, result.BytesReceived));
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }
        // DO THE PROCESSING OF THE PACKET
        static async void ProcessMessageAsync(Memory<byte> data)
        {
            throw new NotImplementedException();
        }
    }
}
