using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class CrashDataUpload : IHandler
    {
        public class CrashDataUploadRspJson
        {
            public int code { get; set; } = 0;
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new CrashDataUploadRspJson());
            return true;
        }
    }
}
