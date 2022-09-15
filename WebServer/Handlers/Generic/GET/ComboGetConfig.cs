using Microsoft.AspNetCore.Http;


namespace Weedwacker.WebServer.Handlers
{
    internal class ComboGetConfig : IHandler
    {
        public class ComboGetConfigResJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; } = new();
            public class Data
            {
                public string id { get; set; } = "none";
                public string action { get; set; } = "ACTION_NONE";
                public string? geetest { get; set; } = null;
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new ComboGetConfigResJson());
            return true;
        }
    }
}
