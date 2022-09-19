namespace Weedwacker.GameServer.Packet
{
    internal abstract class BaseHandler
	{
		protected static byte[] EMPTY_BYTE_ARRAY = Array.Empty<byte>();

		public abstract Task HandleAsync(Connection session, byte[] header, byte[] payload);
	}
}
