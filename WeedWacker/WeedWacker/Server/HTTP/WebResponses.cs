using System.Net;
using System.Text;

namespace Weedwacker.Server.HTTP
{
    internal static class WebResponses
    {
        public static async Task NotFound(HttpListenerResponse resp)
        {
            byte[] data = Encoding.UTF8.GetBytes("Not Found");
            resp.StatusCode = 404;
            resp.ContentType = "text/html";
            resp.ContentEncoding = Encoding.UTF8;
            resp.ContentLength64 = data.LongLength;
            await resp.OutputStream.WriteAsync(data);
            resp.Close();
        }
    }
}
