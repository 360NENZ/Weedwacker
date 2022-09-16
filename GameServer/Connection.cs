using KcpSharp;
using Microsoft.VisualBasic;
using System.Buffers;
using System.Net;
using System.Net.Sockets;

namespace GameServer
{
    internal class Connection
    {
        readonly KcpConversation Conversation;
        readonly CancellationTokenSource CancelToken;
        readonly IPEndPoint RemoteEndPoint;
        public Connection(KcpConversation conversation, IPEndPoint remote)
        {
            Conversation = conversation;
            RemoteEndPoint = remote;
            CancelToken = new CancellationTokenSource();
            Start();           
        }
        async void Start()
        {
            await ReceiveLoop();
        }
        async Task ReceiveLoop()
        {
            while (!CancelToken.IsCancellationRequested)
            {
                // WaitToReceiveAsync call completes when there is at least one message is received or the transport is closed.
                KcpConversationReceiveResult result = await Conversation.WaitToReceiveAsync(CancelToken.Token);
                if (result.TransportClosed)
                {
                    break;
                }
                if (result.BytesReceived > Listener.MaxMessageSize)
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
                    await ProcessMessageAsync(buffer.AsMemory(0, result.BytesReceived));
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }          
        }
        // DO THE PROCESSING OF THE PACKET
        async Task ProcessMessageAsync(Memory<byte> data)
        {
            throw new NotImplementedException();
        }
    }
}
