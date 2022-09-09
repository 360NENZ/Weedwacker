using Weedwacker.Shared.Utils;
using Ceen;

namespace Weedwacker.WebServer.Handlers
{
    internal class QueryRegionList : IHttpModule
    {
        public Task<bool> HandleAsync(IHttpContext context)
        {
            //TODO implement event system and add this event
            context.Response.WriteAllAsync(RegionManager.RegionListResponse);
            // Log to console.
            Logger.WriteLine(string.Format("[Dispatch] Client {0}s request: query_region_list", context.GetRemoteIP()));
            return Task.FromResult(true);
        }

    }
}
