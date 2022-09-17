using KcpSharp;
using Microsoft.VisualBasic;
using System.Buffers;
using System.Net;
using System.Net.Sockets;
using Weedwacker.Shared.Utils;

namespace GameServer
{
    internal class Connection
    {
        public int? ConversationID => Conversation.ConversationId;
        readonly KcpConversation Conversation;
        readonly CancellationTokenSource CancelToken;
        public readonly IPEndPoint RemoteEndPoint;
        public Connection(KcpConversation conversation, IPEndPoint remote)
        {
            Conversation = conversation;
            RemoteEndPoint = remote;
            CancelToken = new CancellationTokenSource();
            Start();           
        }
        async void Start()
        {
            Logger.WriteLine($"New connection to {RemoteEndPoint} created with conversation id {Conversation.ConversationId}");
            await ReceiveLoop();
        }
        void Stop()
        {
            Listener.UnregisterConnection(this);
            Conversation.Dispose();
            CancelToken.Cancel();
            CancelToken.Dispose();
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
                if (result.BytesReceived > Listener.MAX_MSG_SIZE)
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
                catch (Exception ex)
                {
                    Logger.WriteErrorLine("Packet parse error", ex);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
            Stop();
        }
        // DO THE PROCESSING OF THE PACKET
        async Task ProcessMessageAsync(Memory<byte> data)
        {
            throw new NotImplementedException();
        }
    }
}
