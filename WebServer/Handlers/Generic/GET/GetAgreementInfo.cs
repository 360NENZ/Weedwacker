using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class GetAgreementInfo : IHandler
    {
        public class GetAgreementInfoResJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; } = new();
            public class Data
            {
                public string[] marketing_agreements { get; set; } = Array.Empty<string>();
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new GetAgreementInfoResJson());
            return true;
        }
    }
}
