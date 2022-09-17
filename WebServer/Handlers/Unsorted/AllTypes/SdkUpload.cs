
using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class SdkUpload : IHandler
    {
        public class SdkUploadRspJson
        {
            public int code { get; set; } = 0;
        }

        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new SdkUploadRspJson());
            return true;
        }
    }
}
