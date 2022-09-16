using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Weedwacker.WebServer.Handlers
{
    // Known Queries: device_id=REDACTED&platform=2&name=REDACTED HTTP/1.1
    internal class PerfConfigVerify : IHandler
    {
        public class PerfConfigVerifyResJson
        {
            public int code { get; set; } = 0;//,-1
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string message { get; set; } = null;//,"not matched"
        }

        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new PerfConfigVerifyResJson());
            return true;
        }
    }
}

