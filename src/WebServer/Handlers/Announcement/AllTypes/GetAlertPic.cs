using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class GetAlertPic : IHandler
    {
        public class GetAlertPicRspJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; } = new();
            public class Data
            {
                public int total { get; set; } = 0;
                public string[] list { get; set; } = Array.Empty<string>();
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new GetAlertPicRspJson());
            return true;
        }
    }
}
