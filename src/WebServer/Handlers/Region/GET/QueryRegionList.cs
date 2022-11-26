using Microsoft.AspNetCore.Http;
using Weedwacker.Shared.Utils;

namespace Weedwacker.WebServer.Handlers
{
    internal class QueryRegionList : IHandler
    {
        // Known Queries: version=OSRELWin3.0.0&lang=1&platform=3&binary=1&time=257&channel_id=1&sub_channel_id=3 
        public async Task<bool> HandleAsync(HttpContext context)
        {
            //TODO implement event system and add this event
            string rsp = RegionManager.RegionListResponse;
            long contentLength = rsp.Length;
            context.Response.ContentLength = contentLength;
            context.Response.ContentType = "text/plain";
            //context.Response.Headers.Vary = "Accept-Encoding";
            await context.Response.WriteAsync(rsp);
            // Log to console.
            Logger.WriteLine(string.Format("[Dispatch] Client {0}s request: query_region_list", context.Connection.RemoteIpAddress.ToString()));
            return true;
        }

    }
}
