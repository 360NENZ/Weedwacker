using Weedwacker.Shared.Utils;
using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class QueryRegionList : IHandler
    {
        public Task<bool> HandleAsync(HttpContext context)
        {
            //TODO implement event system and add this event
            context.Response.WriteAsync(RegionManager.RegionListResponse);
            // Log to console.
            Logger.WriteLine(string.Format("[Dispatch] Client {0}s request: query_region_list", context.Connection.RemoteIpAddress.ToString()));
            return Task.FromResult(true);
        }

    }
}
