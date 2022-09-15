using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class LogSdkUpload : IHandler
    {
        public class LogSdkUploadResJson
        {
            public int code { get; set; } = 0;
        }

        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new LogSdkUploadResJson());
            return true;
        }
    }
}
