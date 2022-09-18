namespace Weedwacker.GameServer.Packet
{
    internal abstract class BaseHandler
	{
		protected static byte[] EMPTY_BYTE_ARRAY = new byte[0];

		public abstract Task HandleAsync(Connection session, byte[] header, byte[] payload);
	}
}
