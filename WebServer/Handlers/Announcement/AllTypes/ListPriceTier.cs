using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class ListPriceTier :IHandler
    {
        public class ListPriceTiersResJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; } = new();
            public class Data
            {
                public string suggest_currency { get; set; } = "USD";
                public string[] tiers { get; set; } = Array.Empty<string>();
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new ListPriceTiersResJson());
            return true;
        }
    }
}
