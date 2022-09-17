using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    // Known Queries: biz_key=hk4e_global&country_code=REDACTED&token=REDACTED&uid=REDACTED HTTP/1.1
    internal class GetAgreementInfo : IHandler
    {
        public class GetAgreementInfoRspJson
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
            await context.Response.WriteAsJsonAsync(new GetAgreementInfoRspJson());
            return true;
        }
    }
}
