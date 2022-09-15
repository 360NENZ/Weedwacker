using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class GetAlertAnn : IHandler
    {
        public class GetAlertAnnResJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; } = new();
            public class Data
            {
                public bool alert { get; set; } = false;
                public int alert_id { get; set; } = 0;
                public bool remind { get; set; } = true;
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new GetAlertAnnResJson());
            return true;
        }
    }
}
